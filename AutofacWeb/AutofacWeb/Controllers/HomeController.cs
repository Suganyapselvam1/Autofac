using AutofacWeb.Implementation;
using AutofacWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacWeb.Controllers
{
    public class HomeController : Controller
    {
        IRestaurant restaurant;
        IVechile vechile;
        public HomeController()
        {
            restaurant = new Restaurant();
            vechile = new Vechile();
        }
        public ActionResult Index()
        {
            var model = restaurant.GetAll();
            return View(model);
        }

        public ActionResult About()
        {

            var model = vechile.GetMileage();
            ViewBag.Message = "Your application description page.";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}