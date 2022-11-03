using DataAccess.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductDal _productDal;
        private readonly IColorDal _colorDal;
        private readonly ICategoryDal _categoryDal;
        private readonly IProductImageDal _productImageDal;

        public ProductsController(IProductDal productDal, IColorDal colorDal, ICategoryDal categoryDal, IProductImageDal productImageDal)
        {
            _productDal = productDal;
            _colorDal = colorDal;
            _categoryDal = categoryDal;
            _productImageDal = productImageDal;
        }
        public IActionResult ProductDetail(int id)
        {
            var product = _productDal.GetById(id);
            var color = _colorDal.GetById(product.ColorId);
            var category = _categoryDal.GetById(product.CategoryId);
            var productImages = _productImageDal.ProductImages(id);
            var relatedProducts = _productDal.ProductCardListWithCategoryId(product.CategoryId);

            var model = new ProductDetailDto()
            {
                CategoryModel = category,
                ColorModel = color,
                ProductImagesModel = productImages,
                ProductModel = product,
                RelatedProducts = relatedProducts
            };

            return View(model);
        }

        public IActionResult Products(int id)
        {
            var products = new List<ProductCardDto>();

            if (id == 0)
            {
                products = _productDal.ProductCardListAll();
            }
            else
            {
                products = _productDal.ProductCardListWithCategoryId(id);
            }


            var model = new ProductsDto()
            {
                Categories = _categoryDal.GetAll(),
                Products = products,
                Colors = _colorDal.GetAll()
            };
            return View(model);
        }
    }
}
