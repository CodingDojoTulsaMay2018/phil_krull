using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelationshipDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace RelationshipDemo.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Dojo> Dojos = _context.Dojos.ToList();

            Dojo newDojo = new Dojo()
            {
                Name = "Tulsa"
            };
            _context.Add(newDojo);
            _context.SaveChanges();

            Dojo lastDojo = _context.Dojos.Where(dojo => dojo.Id == 1).SingleOrDefault();

            Ninja ninja = new Ninja()
            {
                Name = "Phil",
                Dojo = lastDojo
            };

            lastDojo.Ninjas.Add(ninja);

            _context.Add(ninja);
            _context.SaveChanges();

            return View();
        }

        public IActionResult About()
        {
            Ninja ninja = _context.Ninjas.SingleOrDefault(n => n.Id == 1);

            List<Dojo> allDojos= _context.Dojos.Include(d => d.Ninjas).ToList();

            ViewData["Message"] = "Your application description page.";
            ViewBag.Dojos = allDojos;

            return View();
        }

        [HttpPost]
        public IActionResult AddNinja(Ninja ninja)
        {
            Dojo lastDojo = _context.Dojos.Where(dojo => dojo.Id == 2).SingleOrDefault();
            ninja.Dojo = lastDojo;
            lastDojo.Ninjas.Add(ninja);
            _context.Add(ninja);
            _context.SaveChanges();
            return RedirectToAction("About");
        }

        [HttpPost]
        public IActionResult AddDojo(Dojo dojo)
        {
            _context.Add(dojo);
            _context.SaveChanges();
            return RedirectToAction("About");
        }
        

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewModels myModel = new ViewModels();
            return View(myModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
