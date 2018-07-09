using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DapperTest.Models;
using DbConnection;
using DapperTest.Factory;

namespace DapperTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserFactory _uFactory;
        public HomeController(UserFactory uFactory)
        {
            _uFactory = uFactory;
        }
        public IActionResult Index()
        {
            // List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            IEnumerable<User> AllUsers = _uFactory.FindAll();
            foreach(User user in AllUsers)
            {
                Console.WriteLine(user);
            }
            ViewBag.Users = AllUsers;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _uFactory.Add(user);
            ViewData["Message"] = "Your contact page.";

            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
