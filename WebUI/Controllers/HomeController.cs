using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductDal _productDal;

        public HomeController(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IActionResult Index()
        {
            var model = _productDal.ProductListForHomePage();
            return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }


    }
}
