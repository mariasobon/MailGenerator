﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MailGenerator.Models;

namespace MailGenerator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Example()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            ViewBag.Title = "Example Mail";
            return View();
        }

        public IActionResult Handmade()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            ViewBag.Title = "Handmade Mail";
            return View();
        }

        public IActionResult Asistant()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            ViewBag.Title = "Example Mail";
            return View();
        }

        public IActionResult Masters()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            ViewBag.Title = "Landing Page Masters";
            return View();
        }

        public IActionResult DeepLearning()
        {
            ViewBag.CustomFont = "font-family:'Segoe UI', Roboto, Helvetica, Arial, sans-serif";
            ViewBag.Title = "Example Mail";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
