using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Superheroes.Models;

namespace Superheroes.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("signin")]
        public IActionResult SignIn(string username)
        {
            HttpContext.Session.SetString("username", username);
            return RedirectToAction("Index", "Team");
        }
    }
}