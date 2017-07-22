using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;
using DataModels;

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

            var dishIngredientArray = new DishIngredientDM
            {
                // Leave ID blank when doing insert to auto_increment PK
                DishName = "Tai Lee Chicken2",
                //IngredientId = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray
            };

            await _restaurantManager.AddDishIngredientArray(dishIngredientArray);
            return View();
        }
    }
}
