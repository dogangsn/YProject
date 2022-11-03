using DataAccess.Abstract;
using Entities.Dtos;
using Entities.Entities;
using Helpers.Entities;
using Helpers.Enums;
using Helpers.Messages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebUI.Areas.Admin.Controllers.Base;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : BaseController<ProductsController>
    {
        private readonly IProductDal _productDal;
        private readonly IColorDal _colorDal;
        private readonly IProductImageDal _productImageDal;
        private readonly IHostingEnvironment _environment;

        public ProductsController(IUserDal userDal, IProductDal productDal, IProductImageDal productImageDal, IColorDal colorDal, IHostingEnvironment IHostingEnvironment) : base(userDal)
        {
            _productDal = productDal;
            _colorDal = colorDal;
            _productImageDal = productImageDal;
            _environment = IHostingEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductList()
        {
            var draw = Request.Form["draw"].FirstOrDefault();
            var start = Request.Form["start"].FirstOrDefault();
            var length = Request.Form["length"].FirstOrDefault();
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? ((Convert.ToInt32(start) / Convert.ToInt32(length)) + 1) : 1;
            int recordsTotal = 0;
            var data = _productDal.ProductList(Convert.ToInt32(length), skip == 0 ? 1 : skip, searchValue);
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                if (sortColumnDirection == "asc")
                {
                    if (sortColumn == "ProductId")
                        data = data.OrderBy(x => x.ProductId).ToList();
                    else if (sortColumn == "CategoryName")
                        data = data.OrderBy(x => x.CategoryName).ToList();
                    else if (sortColumn == "ColorName")
                        data = data.OrderBy(x => x.ColorName).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderBy(x => x.Name).ToList();
                    else if (sortColumn == "Price1")
                        data = data.OrderBy(x => x.Price1).ToList();
                    else if (sortColumn == "Price2")
                        data = data.OrderBy(x => x.Price2).ToList();
                    else if (sortColumn == "Stock")
                        data = data.OrderBy(x => x.Stock).ToList();
                    else if (sortColumn == "IsActive")
                        data = data.OrderBy(x => x.IsActive).ToList();
                    else if (sortColumn == "OrderNumber")
                        data = data.OrderBy(x => x.OrderNumber).ToList();
                    else if (sortColumn == "Barcode")
                        data = data.OrderBy(x => x.Barcode).ToList();
                    else if (sortColumn == "ShowHomePage")
                        data = data.OrderBy(x => x.ShowHomePage).ToList();
                }
                else
                {
                    if (sortColumn == "ProductId")
                        data = data.OrderByDescending(x => x.ProductId).ToList();
                    else if (sortColumn == "CategoryName")
                        data = data.OrderByDescending(x => x.CategoryName).ToList();
                    else if (sortColumn == "ColorName")
                        data = data.OrderByDescending(x => x.ColorName).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderByDescending(x => x.Name).ToList();
                    else if (sortColumn == "Price1")
                        data = data.OrderByDescending(x => x.Price1).ToList();
                    else if (sortColumn == "Price2")
                        data = data.OrderByDescending(x => x.Price2).ToList();
                    else if (sortColumn == "Stock")
                        data = data.OrderByDescending(x => x.Stock).ToList();
                    else if (sortColumn == "IsActive")
                        data = data.OrderByDescending(x => x.IsActive).ToList();
                    else if (sortColumn == "OrderNumber")
                        data = data.OrderByDescending(x => x.OrderNumber).ToList();
                    else if (sortColumn == "Barcode")
                        data = data.OrderByDescending(x => x.Barcode).ToList();
                    else if (sortColumn == "ShowHomePage")
                        data = data.OrderByDescending(x => x.ShowHomePage).ToList();
                }
            }
            recordsTotal = data.Count > 0 ? data.FirstOrDefault().TotalRecords : 0;
            return Ok(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpPost]
        public IActionResult ProductSave(ProductModel product)
        {
            if (product != null)
            {
                if (product.ProductId == 0)
                {
                    var model = new ProductModel()
                    {
                        CategoryId = product.CategoryId,
                        ColorId = product.ColorId,
                        Name = product.Name,
                        Description = product.Description,
                        Price1 = product.Price1,
                        Price2 = product.Price2,
                        Barcode = product.Barcode,
                        ShowHomePage = product.ShowHomePage,
                        Stock = product.Stock,
                        IsActive = true,
                        OrderNumber = product.OrderNumber
                    };
                    var responseProduct = _productDal.Add(model);

                    if (product.IProductImages != null)
                    {
                        byte i = 0;
                        foreach (IFormFile file in product.IProductImages)
                        {
                            if (file.Length > 0)
                            {
                                i++;
                                var fileName = "";
                                string PathDB = "";
                                var newFileName = "";
                                var FileExtension = Path.GetExtension(file.FileName);
                                newFileName = i + "_" + Guid.NewGuid().ToString() + FileExtension;
                                fileName = Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}" + $@"\{newFileName}";
                                PathDB = "/ProductImages/" + responseProduct.ProductId + "/" + newFileName;
                                Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}");
                                using FileStream fs = System.IO.File.Create(fileName);
                                file.CopyTo(fs);
                                fs.Flush();

                                var imageModel = new ProductImageModel()
                                {
                                    ProductId = responseProduct.ProductId,
                                    ImagePath = PathDB,
                                    OrderNumber = i
                                };
                                _productImageDal.Add(imageModel);
                            }
                        }
                    }



                    NResult<ProductModel> nResult = new()
                    {
                        Data = model,
                        Message = Message.Success,
                        ResponseType = ResponseType.Success
                    };
                    return Ok(nResult);
                }
                else
                {
                    var model = _productDal.GetById(product.ProductId);
                    model.CategoryId = product.CategoryId;
                    model.Name = product.Name;
                    model.IsActive= product.IsActive;
                    model.ColorId = product.ColorId;
                    model.Description = product.Description;
                    model.Price1 = product.Price1;
                    model.ShowHomePage = product.ShowHomePage;
                    model.Price2 = product.Price2;
                    model.Barcode = product.Barcode;
                    model.Stock = product.Stock;
                    model.OrderNumber = product.OrderNumber;
                    var responseProduct = _productDal.Update(model);

                    if (product.IProductImages != null)
                    {
                        _productImageDal.ProductImagesDelete(responseProduct.ProductId);

                        if (Directory.Exists(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}"))
                        {
                            Directory.Delete(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}", true);
                        }

                        byte i = 0;
                        foreach (IFormFile file in product.IProductImages)
                        {
                            if (file.Length > 0)
                            {
                                i++;
                                var fileName = "";
                                string PathDB = "";
                                var newFileName = "";
                                var FileExtension = Path.GetExtension(file.FileName);
                                newFileName = i + "_" + Guid.NewGuid().ToString() + FileExtension;
                                fileName = Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}" + $@"\{newFileName}";
                                PathDB = "/ProductImages/" + responseProduct.ProductId + "/" + newFileName;
                                Directory.CreateDirectory(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{responseProduct.ProductId}");
                                using FileStream fs = System.IO.File.Create(fileName);
                                file.CopyTo(fs);
                                fs.Flush();

                                var imageModel = new ProductImageModel()
                                {
                                    ProductId = responseProduct.ProductId,
                                    ImagePath = PathDB,
                                    OrderNumber = i
                                };
                                _productImageDal.Add(imageModel);
                            }
                        }
                    }



                    NResult<ProductModel> nResult = new()
                    {
                        Data = model,
                        Message = Message.Success,
                        ResponseType = ResponseType.Success
                    };
                    return Ok(nResult);
                }
            }
            else
            {
                NResult nResult = new()
                {
                    Message = Message.Failed,
                    ResponseType = ResponseType.Error
                };
                return Ok(nResult);
            }
        }

        [HttpGet]
        public IActionResult ProductGet(int id)
        {
            var model = _productDal.ProductGet(id);
            var productImages = _productImageDal.ProductImages(id);
            model.ProductImages = productImages;
            NResult<ProductModel> nResult = new()
            {
                Data = model,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }

        [HttpPost]
        public IActionResult ProductDelete(int id)
        {
            NResult nResult = new();
            int productDelete = _productDal.ProductDelete(id);

            if (productDelete > 0)
            {
                if (Directory.Exists(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{id}"))
                {
                    Directory.Delete(Path.Combine(_environment.WebRootPath, "ProductImages") + $@"\{id}", true);
                }
                _productImageDal.ProductImagesDelete(id);
            }
            if (productDelete > 0)
            {
                nResult.Message = Message.Success;
                nResult.ResponseType = ResponseType.Success;
            }
            else
            {
                nResult.Message = Message.Error;
                nResult.ResponseType = ResponseType.Error;
            }
            return Ok(nResult);
        }

        [HttpGet]
        public IActionResult CategoryListForProduct()
        {
            var model = _productDal.CategoryListForProduct().OrderBy(x => x.Name).ToList();
            NResult<List<CategoryListForProductDto>> nResult = new()
            {
                Data = model,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }
        [HttpGet]
        public IActionResult ColorListForProduct()
        {
            var model = _colorDal.GetAll().OrderBy(x => x.Name).ToList();

            NResult<List<ColorModel>> nResult = new()
            {
                Data = model,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }

        [HttpGet]
        public IActionResult CreateBarcode()
        {

            Random rnd = new();
            int randomBarcode = rnd.Next(100, 9999);
            string barcode = "869007007" + randomBarcode; 

            NResult<string> nResult = new()
            {
                Data = barcode,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }

    }
}
