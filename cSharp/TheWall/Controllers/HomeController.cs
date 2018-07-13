using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;

namespace TheWall.Controllers
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
            List<User> Users = _context.Users.ToList();
            List<Message> Messages = _context.Messages.ToList();

            return View();
        }

        public IActionResult About()
        {
            MessagesAndPosts ViewModels = new MessagesAndPosts()
            {
                Posts = new Post(),
                Messages = new Message()
            };

            return View(ViewModels);
        }

        [HttpPost]
        public IActionResult addMessage(Message message)
        {
            User newUser = new User()
            {
                First_name = "Tom"
            };

            Console.WriteLine(message.Content);

            _context.Add(newUser);
            _context.SaveChanges();
            User user = _context.Users.Last();

            message.Creator = user;

            _context.Add(message);
            _context.SaveChanges();

            Message saveMessage = _context.Messages.Last();

            user.Messages.Add(saveMessage);

            _context.SaveChanges();

            return RedirectToAction("Index");

        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
