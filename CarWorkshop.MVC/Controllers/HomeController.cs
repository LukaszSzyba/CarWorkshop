using System.Diagnostics;
using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Adam",
                    LastName = "Kowalski"
                },
                new Person()
                {
                    FirstName = "Jakub",
                    LastName = "Jakubiak"
                },
            };

            return View(model);
        }
        public IActionResult About()
        {
            var model = new List<About>()
            {
                new About() 
                {
                    Title = "W pustyni i w puszczy",
                    Description="Wspania³a powieœæ",
                    Tags = ["lektura", "powiesc", "Coœ tam"]
                },
                new About()
                {
                    Title = "Testowa ksiazka",
                    Description="testowy wpis",
                    Tags = ["lektura", "testy", "Jaœ"]
                }

            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
