﻿using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMiles.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mary";
            ViewBag.BD = 99999.99;
            return View();
        }
    }
}
