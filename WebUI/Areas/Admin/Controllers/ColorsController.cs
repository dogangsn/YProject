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
    public class ColorsController : BaseController<ColorsController>
    {
        private readonly IColorDal _colorDal;

        public ColorsController(IUserDal userDal, IColorDal colorDal) : base(userDal)
        {
            _colorDal = colorDal;
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
        public IActionResult ColorList()
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
            var data = _colorDal.ColorList(Convert.ToInt32(length), skip == 0 ? 1 : skip, searchValue);
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                if (sortColumnDirection == "asc")
                {
                    if (sortColumn == "ColorId")
                        data = data.OrderBy(x => x.ColorId).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderBy(x => x.Name).ToList();
                }
                else
                {
                    if (sortColumn == "ColorId")
                        data = data.OrderByDescending(x => x.ColorId).ToList();
                    else if (sortColumn == "Name")
                        data = data.OrderByDescending(x => x.Name).ToList();
                }
            }

            recordsTotal = data.Count > 0 ? data.FirstOrDefault().TotalRecords : 0;
            return Ok(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpPost]
        public IActionResult ColorSave(ColorModel color)
        {
            if (color != null)
            {
                if (color.ColorId == 0)
                {
                    var model = new ColorModel()
                    {
                        Name = color.Name
                    };
                    _colorDal.Add(model);
                    NResult<ColorModel> nResult = new()
                    {
                        Data = model,
                        Message = Message.Success,
                        ResponseType = ResponseType.Success
                    };
                    return Ok(nResult);
                }
                else
                {
                    var model = _colorDal.GetById(color.ColorId);
                    model.Name = color.Name;
                    _colorDal.Update(model);
                    NResult<ColorModel> nResult = new()
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
        public IActionResult ColorGet(int id)
        {
            var model = _colorDal.GetById(id);
            NResult<ColorModel> nResult = new()
            {
                Data = model,
                Message = Message.Success,
                ResponseType = ResponseType.Success
            };
            return Ok(nResult);
        }

        [HttpPost]
        public IActionResult ColorDelete(int id)
        {
            NResult nResult = new NResult();
            var result = _colorDal.ColorDelete(id);
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
