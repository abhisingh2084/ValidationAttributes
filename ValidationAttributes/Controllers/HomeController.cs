using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttributes.Models;

namespace ValidationAttributes.Controllers
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

        [HttpPost]
        public string Index(Student std)
        {
            if(ModelState.IsValid) 
            { 
                return "Student Name : " + std.Name; 
            }
            else
            {
                return "Validation fail.....";
            }
           
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
