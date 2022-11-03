using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Areas.Admin.Controllers.Base;

namespace WebUI.Areas.Admin.Controllers
{
    public class AdminController : BaseController<AdminController>
    {
        public AdminController(IUserDal userDal) : base(userDal)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
