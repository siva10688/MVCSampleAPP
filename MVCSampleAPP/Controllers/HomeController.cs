﻿using Microsoft.AspNetCore.Mvc;
using MVCSampleAPP.Models;
using System.Diagnostics;

namespace MVCSampleAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }


        public ViewResult ForgotPassword()
        {
            var name = "raju";

            if (name == "raju")
            {
                return View("ForgotPwd");

            }
            else
            {
                return View("~/Views/Home/ResetPwd.cshtml");
            }
        }

        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }

        public ViewResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}