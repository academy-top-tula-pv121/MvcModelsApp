using Microsoft.AspNetCore.Mvc;
using MvcModelsApp.Models;
using System.Diagnostics;

namespace MvcModelsApp.Controllers
{
    public class HomeController : Controller
    {
        List<User> users = new()
        {
            new(1, "Bob", 27),
            new(2, "Joe", 31),
            new(3, "Leo", 19),
            new(4, "Jim", 24),
            new(5, "Sam", 36),
        };

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}