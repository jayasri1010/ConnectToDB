using Logindetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace Logindetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //create dbcontext variable
        private readonly MyDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger,MyDbContext dbContext)
        {
            _logger = logger;
            if(_dbContext== null)
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.usersDetails.ToList();

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