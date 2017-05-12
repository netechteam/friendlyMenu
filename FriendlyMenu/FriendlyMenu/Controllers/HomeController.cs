using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendlyMenu.Data;
using FriendlyMenu.Models;
using Microsoft.AspNetCore.Mvc;

namespace FriendlyMenu.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestaurantRepository _restaurantRepository;

        public HomeController(DatabaseContext databaseContext)
        {
            _restaurantRepository = new RestaurantRepository(databaseContext);
        }
        public IActionResult Index()
        {
            var restaurant = _restaurantRepository.GetRestaurant(1);

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
