﻿using System.Web.Mvc;

namespace DeveloperMediaDemo.Controllers
{
    public class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}