using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace FriendlyMenu.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantManager _restaurantManager;

        public RestaurantController(IRestaurantManager restaurantManager)
        {
            _restaurantManager = restaurantManager;
        }

        public async Task<IActionResult> Index()
        {
            var restaurant = await _restaurantManager.GetRestaurant(1);

            return View();
        }
    }
}
