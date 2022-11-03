using DataAccess.Abstract;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace WebUI.Areas.Admin.Controllers.Base
{
    [Area("Admin")]
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private readonly IUserDal _userDal;
        public LoaderModel Loader { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int PageId { get; set; }
        protected BaseController(IUserDal userDal)
        {
            _userDal = userDal;
            Loader = new LoaderModel();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            ControllerName = Convert.ToString(RouteData.Values["controller"]);
            ActionName = Convert.ToString(RouteData.Values["action"]);
            PageId = Convert.ToInt32(RouteData.Values["id"]);
            ViewBag.ControllerName = ControllerName;
            ViewBag.ActionName = ActionName;
            ViewBag.PageId = PageId;
            if (LoginIsActive() == false)
            {
                //context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                //{
                //    controller = "login",
                //    action = "index"
                //}));

                context.Result = Redirect("/admin/login/index");

                return;
            }
            else
            {
                if (Loader.User == null)
                {
                    Loader = new LoaderModel()
                    {
                        User = _userDal.GetById(Convert.ToInt32(User.Identity.Name))
                    };
                }
                ViewBag.loader = Loader;
            }

        }
        public bool LoginIsActive()
        {
            if (User.Identity.Name == null)
                return false;
            return true;
        }
    }
}
