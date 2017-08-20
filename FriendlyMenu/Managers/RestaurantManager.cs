using System;
using System.Threading.Tasks;
using DataModels;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace Managers
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly IRestaurantDataAccessor _restaurantDataAccessor;
        //private readonly IAddressDataAccessor _addressDataAccessor;
        //private readonly IDishIngredientDataAccessor _dishIngredientDataAccessor;

        public RestaurantManager(IRestaurantDataAccessor restaurantDataAccessor)
        {
            _restaurantDataAccessor = restaurantDataAccessor;
           
        }

        public async Task<CategoryPageVM> GetDishesByCategory(int categoryId, int restaurantId)
        { 

            var categoryDishes = await _restaurantDataAccessor.GetDishesByCategory(categoryId, restaurantId);

            
            var categoryPage = new CategoryPageVM
            {
                CategoryName = categoryDishes.CategoryName,
                Dishes = categoryDishes.DishSummaryDM.Select( x => new DishSummaryVM
                {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    DishName = x.DishName,
                    IsBreakfast = x.IsBreakfast,
                    IsCombo = x.IsCombo,
                    IsLunch = x.IsLunch,
                    IsSpicy = x.IsSpicy,
                    PriceBreakfast = x.PriceBreakfast,
                    PriceCombo = x.PriceCombo,
                    PriceDinner = x.PriceDinner,
                    PriceLunch = x.PriceLunch,
                    RestaurantId = x.RestaurantId,
                    Ingredients = string.Join(", ", x.Ingredients.Select(y => y.IngredientName))
                    
                }).ToList()
            };


            return categoryPage;
        }

  
    }
}
