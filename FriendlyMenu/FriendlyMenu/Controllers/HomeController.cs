using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace FriendlyMenu.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantManager _restaurantManager;

        public HomeController(IRestaurantManager restaurantManager)
        {
            _restaurantManager = restaurantManager;
        }
        public async Task<IActionResult> Index()
        {
            //var restaurant = await _restaurantManager.GetRestaurant(1);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
