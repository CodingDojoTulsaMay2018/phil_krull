using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using Microsoft.AspNetCore.Http;

namespace RockPaperScissors.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string[] possibilities = {"rock", "paper", "scissors"};
            if(TempData["choice"] != null)
            {
                int choice = Convert.ToInt32(TempData["choice"]);
                Random rand = new Random();
                string result;
                int serverChoice = rand.Next(0,3);
                StringBuilder sb = new StringBuilder();
                sb.Append("You choose ");
                sb.Append(possibilities[choice]);
                sb.Append(" and the server choose ");
                sb.Append(possibilities[serverChoice]);
                if(choice == 0 && serverChoice == 1) {
                    // server won
                    result = "lost";
                    int? num = HttpContext.Session.GetInt32("Lost");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Lost", num.GetValueOrDefault());
                } else if(choice == 0 && serverChoice == 2) {
                    // server lost
                    result = "won";
                    int? num = HttpContext.Session.GetInt32("Won");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Won", num.GetValueOrDefault());
                } else if(choice == 1 && serverChoice == 0) {
                    // server lost
                    result = "won";
                    int? num = HttpContext.Session.GetInt32("Won");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Won", num.GetValueOrDefault());
                } else if(choice == 1 && serverChoice == 2) {
                    // server won
                    result = "lost";
                    int? num = HttpContext.Session.GetInt32("Lost");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Lost", num.GetValueOrDefault());
                } else if(choice == 2 && serverChoice == 0) {
                    // server won
                    result = "lost";
                    int? num = HttpContext.Session.GetInt32("Lost");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Lost", num.GetValueOrDefault());
                } else if(choice == 2 && serverChoice == 1) {
                    // server lost
                    result = "won";
                    int? num = HttpContext.Session.GetInt32("Won");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Won", num.GetValueOrDefault());
                } else {
                    result = "tied";
                    int? num = HttpContext.Session.GetInt32("Tied");
                    Console.WriteLine(num);
                    num = num + 1;
                    HttpContext.Session.SetInt32("Tied", num.GetValueOrDefault());
                }
                sb.Append($", you {result}");
                ViewBag.result = sb;
            } else {
                HttpContext.Session.SetInt32("Tied", 0);
                HttpContext.Session.SetInt32("Won", 0);
                HttpContext.Session.SetInt32("Lost", 0);
                ViewBag.result = "Begin your game!";
            }
            Console.WriteLine(HttpContext.Session.GetInt32("Tied"));
            Console.WriteLine(HttpContext.Session.GetInt32("Won"));
            Console.WriteLine(HttpContext.Session.GetInt32("Lost"));
            ViewBag.tied = HttpContext.Session.GetInt32("Tied");
            ViewBag.won = HttpContext.Session.GetInt32("Won");
            ViewBag.lost = HttpContext.Session.GetInt32("Lost");
            return View();
        }
        [HttpPost]
        public IActionResult Process(string choice)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"The choice is: {choice}");
            TempData["choice"] = Int32.Parse(choice);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
