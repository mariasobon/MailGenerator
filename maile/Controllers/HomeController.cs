using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace maile.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Promo()
        {
            ViewBag.Message = "Title";

            return View();
        }

        public ActionResult Daily()
        {
            ViewBag.Title = "Ceneo Daily News";
            return View();
        }

        public ActionResult Xmas_Promo()
        {
            ViewBag.Title = "Xmas Promo";
            return View();
        }

        public ActionResult FeatureMatrix()
        {
           return View();
        }

        public ActionResult QA_Shops()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            return View();
        }

        public ActionResult QA_Uphold()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            return View();
        }

        public ActionResult ZO_naklejki()
        {
            return View();
        }

        public ActionResult Newsletter_zapach()
        {
            return View();
        }
    }
}