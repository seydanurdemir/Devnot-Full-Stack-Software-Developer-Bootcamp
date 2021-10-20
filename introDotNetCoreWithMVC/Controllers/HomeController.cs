﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "SeydaNur";
            ViewBag.IsRedPill = true;

            ViewBag.Products = new string[] { "Soda", "Cola", "Ayran", "Kahve" };

            //return BadRequest();
            //return Ok();
            return View();
        }

        //public string Index()
        //{
        //    return "Burasi Home/Index tir.";
        //}
    }
}