using System;
using System.Threading.Tasks;
using DataModels;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using ViewModels;
using System.Linq;
using System.Collections.Generic;
using Extensions;

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

            var categoryPage = GetCategoryPageVM(categoryDishes);

            return categoryPage;
        }

        private static CategoryPageVM GetCategoryPageVM(CategoryDishesDM categoryDishes)
        {
            if (categoryDishes == null)
                return null;

            return new CategoryPageVM
            {
                CategoryName = categoryDishes.CategoryName,
                Dishes = categoryDishes.DishSummaries.Select(x => new DishSummaryVM
                {
                    DishId = x.DishId,
                    //CategoryId = x.CategoryId,
                    Description = x.Description,
                    DishName = x.DishName,
                    IsBreakfast = x.IsBreakfast,
                    IsCombo = x.IsCombo,
                    IsLunch = x.IsLunch,
                    IsSpicy = x.IsSpicy,
                    BreakfastPrice = x.BreakfastPrice,
                    ComboPrice = x.ComboPrice,
                    DinnerPrice = x.DinnerPrice,
                    LunchPrice = x.LunchPrice,
                    Ingredients = string.Join(", ", x.Ingredients.EmptyIfNull().Select(y => y.IngredientName)),
                    ImageUrl = "/Images/dishImages/ChinaWall/" + x.ImageUrl   //todo need to fix this hard code
                }).ToList()
            };
        }
    }
}
