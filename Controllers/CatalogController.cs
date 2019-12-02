using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab2.Models;

namespace lab2.Controllers
{
    public class CatalogController : Controller {
        

        // default page
        // to show the catalog of CARS available to rent
        public IActionResult Index(){
            return View();

        }

        public IActionResult Register(){
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar (  Car theCar ){
            
            Console.WriteLine("************************************");
            Console.WriteLine("************************************");

            Console.WriteLine("User wants to save a car year:", theCar);

            Console.WriteLine("************************************");
            Console.WriteLine("************************************");

            return Json(theCar);



        }
        // register form 
        // ...
    }
}



