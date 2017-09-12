using System;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DbModels;
using Entities;
using Interfaces.DataAccessors;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Remotion.Linq.Clauses;

namespace DataAccessors
{
    public class RestaurantDataAccessor : IRestaurantDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public RestaurantDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }



        public async Task<CategoryDishesDM> GetDishesByCategory(int categoryId, int restaurantId)
        {
            var allDBDishes = _databaseContext.Dish.Where(x => x.RestaurantId == restaurantId && x.CategoryId == categoryId).Select(y => new DishSummaryDM
            {
                Id = y.Id,
                RestaurantId = y.RestaurantId,
                DishName = y.DishName,
                Description = y.Description,
                CategoryId = y.CategoryId,
                IsBreakfast = y.IsBreakfast,
                IsCombo = y.IsCombo,
                IsLunch = y.IsLunch,
                IsSpicy = y.IsSpicy,
                PriceBreakfast = y.PriceBreakfast,
                PriceCombo = y.PriceCombo,
                PriceDinner = y.PriceDinner,
                PriceLunch = y.PriceLunch,
                Ingredients = (from di in _databaseContext.DishIngredients
                               join i in _databaseContext.Ingredient on di.IngredientId equals i.Id
                               where di.DishId == y.Id
                               select new IngredientDM
                               {
                                   Id = di.IngredientId,
                                   IngredientName = i.IngredientName
                               }).ToList(), 
                ImageUrl = (from image in _databaseContext.DishImage
                              join d in _databaseContext.Dish on image.DishId equals d.Id
                              where  image.DishId == y.Id select image.ImageLocation).FirstOrDefault()
            }).ToList();

            var categoryName = (from x in _databaseContext.Category where x.Id == categoryId select x.CategoryName).First();
            var categoryDishes = new CategoryDishesDM
            {
                CategoryName = categoryName,
                DishSummaryDM = allDBDishes

            };
            return categoryDishes;
        }
        
    }
}
