using FoodFIghtAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using FoodFIghtAdmin.ViewModels;

namespace FoodFIghtAdmin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FoodFightContext _context;

        public HomeController(ILogger<HomeController> logger, FoodFightContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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
        public IActionResult Details()
        {
            var users = from u in _context.Users
                        select u;
            var restaurants = from r in _context.Restaurants
                              select r;
            var matchSessions = from ms in _context.MatchSessions
                                select ms;
            var connectedUsers = from cu in _context.ConnectedUsers
                                 select cu;
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel(users, restaurants, matchSessions, connectedUsers);
            return View(homeDetailsViewModel);
        }
    }
}
