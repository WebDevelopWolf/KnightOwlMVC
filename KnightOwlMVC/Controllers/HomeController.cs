using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnightOwlMVC.Models;
using KnightOwlMVC.Models.EventsModels;
using KnightOwlMVC.ViewModels;

namespace KnightOwlMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dashboardviewmodel = new DashboardViewModel();
            return View(dashboardviewmodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}