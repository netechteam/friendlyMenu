using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;
using DataModels;
using ViewModels;
using Misc;

namespace FriendlyMenu.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantManager _restaurantManager;
        private readonly AppTenant _tenant;

        public RestaurantController(IRestaurantManager restaurantManager, AppTenant tenant)
        {
            if (tenant == null)
                throw new NullReferenceException("tenant object cannot be null");

            _restaurantManager = restaurantManager;
            _tenant = tenant;

        }

        public async Task<IActionResult> Index()
        {
            var homePageVM = await _restaurantManager.GetHomePageByRestaurantId(_tenant.RestaurantId);
            return View(homePageVM);
        }

        [Route("category/{categoryId}")]
        public async Task<IActionResult> CategoryPage(int categoryId)
        {
            var viewModel = await _restaurantManager.GetDishesByCategory(categoryId, _tenant.RestaurantId);

            return View(viewModel);
        }


        //[Route("menu/{id}")]
        //public async Task<IActionResult> Menu(int id)
        //{

        //    var viewModel = new MenuPageVM
        //    {
        //        MenuTitle = "Beef",
        //        Dishes = new List<DishSummaryVM>
        //        {
        //            new DishSummaryVM
        //            {
        //                Description = "Seafood",
        //                ImageUrl = "http://dolerecipe.dolesunshine.com/RecipeImages/3397/Sweet%20Sour%20Shrimp%201000x383.jpg",
        //                //Ingredients = "Shrimps",
        //                //Name = "Sweet & Sour Shrimp",
        //                //Price = "$6.66"
        //            },

        //            new DishSummaryVM
        //            {
        //                Description = "Beef",
        //                ImageUrl = "http://www.creekstonefarms.com/media/recipes/52/lg.jpg",
        //                //Ingredients = "Beef, broccoli",
        //                //Name = "Beef w. Broccoli",
        //                //Price = "$6.66"
        //            }
        //        }

        //    };

        //    return View(viewModel);
        //}
    }

    // http://benfoster.io/blog/asp-net-5-multitenancy

}
