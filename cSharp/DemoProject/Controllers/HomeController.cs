using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoProject.Models;

namespace DemoProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Phil cloneOne = new Phil()
            {
                Name = "Lihp"
            };
            Console.WriteLine($"Phil class name is: {cloneOne.Name}");
            Console.WriteLine($"Phil class height is: {cloneOne.Height}");

            return View(cloneOne);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Test()
        {
            ViewData["Message"] = "From the test method";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
