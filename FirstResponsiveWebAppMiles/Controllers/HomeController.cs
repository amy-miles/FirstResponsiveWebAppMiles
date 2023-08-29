using FirstResponsiveWebAppMiles.Models;
using Microsoft.AspNetCore.Mvc;
namespace FirstResponsiveWebAppMiles.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            ViewBag.BD = null;
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculateAgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BD = model.CalculateAge();
            }
            else { ViewBag.BD = null; }
            
            return View(model);
        }
    }
}
