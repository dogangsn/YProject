using DataAccess.Abstract;
using Entities.Entities;
using Helpers.Entities;
using Helpers.Enums;
using Helpers.Messages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebUI.Areas.Admin.Controllers.Base;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : BaseController<CategoriesController>
    {
        private readonly ICategoryDal _categoryDal;
        public CategoriesController(IUserDal userDal, ICategoryDal categoryDal) : base(userDal)
        {
            _categoryDal = categoryDal;
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
        public IActionResult CategoryList()
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
            var data = _categoryDal.CategoryList(Convert.ToInt32(length), skip == 0 ? 1 : skip, searchValue);
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                if (sortColumnDirection == "asc")
                {
                    if (sortColumn == "CategoryId")
                        data = data.OrderBy(x => x.CategoryId).ToList();
                    else if (sortColumn == "OrderNumber")
                        data = data.OrderBy(x => x.OrderNumber).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderBy(x => x.Name).ToList();
                }
                else
                {
                    if (sortColumn == "CategoryId")
                        data = data.OrderByDescending(x => x.CategoryId).ToList();
                    else if (sortColumn == "OrderNumber")
                        data = data.OrderByDescending(x => x.OrderNumber).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderByDescending(x => x.Name).ToList();
                }
            }

            recordsTotal = data.Count > 0 ? data.FirstOrDefault().TotalRecords : 0;
            return Ok(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpPost]
        public IActionResult CategorySave(CategoryModel category)
        {
            if (category != null)
            {
                if (category.CategoryId == 0)
                {
                    var model = new CategoryModel()
                    {
                        Name = category.Name,
                        OrderNumber = category.OrderNumber
                    };
                    _categoryDal.Add(model);
                    NResult<CategoryModel> nResult = new()
                    {
                        Data = model,
                        Message = Message.Success,
                        ResponseType = ResponseType.Success
                    };
                    return Ok(nResult);
                }
                else
                {
                    var model = _categoryDal.GetById(category.CategoryId);
                    model.Name = category.Name;
                    model.OrderNumber = category.OrderNumber;
                    _categoryDal.Update(model);
                    NResult<CategoryModel> nResult = new()
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
                NResult nResult = new NResult()
                {
                    Message = Message.Failed,
                    ResponseType = ResponseType.Error
                };
                return Ok(nResult);
            }
        }

        [HttpGet]
        public IActionResult CategoryGet(int id)
        {
            var model = _categoryDal.CategoryGet(id);
            NResult<CategoryModel> nResult = new NResult<CategoryModel>()
            {
                Data = model,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }

        [HttpPost]
        public IActionResult CategoryDelete(int id)
        {
            NResult nResult = new NResult();
            var result = _categoryDal.CategoryDelete(id);
            if (result > 0)
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
    }
}
