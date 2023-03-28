using ConnectToDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ConnectToDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly dbContext _dbContext;
        public HomeController(ILogger<HomeController> logger, dbContext dbContext)
        {
            _logger = logger;
            if(_dbContext== null)
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.UsersDetails.ToList();

            return View(data);
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