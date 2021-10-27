using introDotNetCoreWithMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        //Controller da olusan bi verinin View e gonderilmesi
        //Koleksiyonlar 1.Model 2.ViewBack ViewData 4.TempData

        public IActionResult useModel()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink { Name = "Su", Price = 1.5},
                new Drink { Name = "Soda", Price = 3},
                new Drink { Name = "Cola", Price = 7.5},
                new Drink { Name = "Kahve", Price = 8}
            };

            return View(drinks);
        }

        public IActionResult UserRegister()
        {

            return View();
        }

        [HttpPost]

        //public IActionResult UserRegister(User user, IFormCollection formCollection)
        //{
        //    return View();
        //}
        public IActionResult UserRegister(User user)
        {
            if (ModelState.IsValid)
            {
                // modelstate bu action a gonderilen parametrenin kurallara uyup uymadigini denetler
            }
            return View();
        }
    }
}
