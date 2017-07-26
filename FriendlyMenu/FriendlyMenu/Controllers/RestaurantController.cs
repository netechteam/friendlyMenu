using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;
using DataModels;
using ViewModels;

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
                DishName = "Thien Be De Chicken2",
                //IngredientId = new List<int> { 1, 2, 3, 4, 5, 6 }.ToArray
            };

            //await _restaurantManager.AddDishIngredientArray(dishIngredientArray);
            return View();
        }

        [Route("menu/{id}")]
        public async Task<IActionResult> Menu(int id)
        {

            var viewModel = new MenuPageVM
            {
                MenuTitle = "Beef",
                Dishes = new List<DishSummaryVM>
                {
                    new DishSummaryVM
                    {
                        Description = "Seafood",
                        ImageUrl = "http://dolerecipe.dolesunshine.com/RecipeImages/3397/Sweet%20Sour%20Shrimp%201000x383.jpg",
                        Ingredients = "Shrimps",
                        Name = "Sweet & Sour Shrimp",
                        Price = "$6.66"
                    },

                    new DishSummaryVM
                    {
                        Description = "Beef",
                        ImageUrl = "http://www.creekstonefarms.com/media/recipes/52/lg.jpg",
                        Ingredients = "Beef, broccoli",
                        Name = "Beef w. Broccoli",
                        Price = "$6.66"
                    }
                }

            };

            return View(viewModel);
        }
    }
}
