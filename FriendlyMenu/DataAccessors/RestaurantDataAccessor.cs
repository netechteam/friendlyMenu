using System;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DbModels;
using Entities;
using Interfaces.DataAccessors;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccessors
{
    public class RestaurantDataAccessor : IRestaurantDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public RestaurantDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<DishDM>> GetAllDishes(int restaurantId)
        {
            return (from r in _databaseContext.Restaurant
                    join d in _databaseContext.Dish on r.Id equals d.RestaurantId
                    join di in _databaseContext.DishIngredients on d.Id equals di.DishId
                    where r.Id == restaurantId select new DishDM
                    {
                        Id = di.Id,
                        RestaurantId = d.RestaurantId,
                        MenuCategoryId = d.MenuCategoryId,
                        DishName = d.DishName,
                        Description = d.Description,
                        PriceBreakfast = d.PriceBreakfast,
                        PriceLunch = d.PriceLunch,
                        PriceCombo = d.PriceCombo,
                        PriceDinner = d.PriceDinner,
                        IsBreakfast = d.IsBreakfast,
                        IsLunch = d.IsLunch,
                        IsCombo = d.IsCombo,
                        IsSpicy = d.IsSpicy,
                        Ingredients = _databaseContext.Ingredient.Select(x => new IngredientDM
                        {
                            Id = x.Id,
                            IngredientName = x.IngredientName,
                            IngredientTypeId = x.IngredientTypeId
                        }).ToList()
                    }
                ).ToList();
        }

        //public List<IngredientDM> SetDishIngredients(int[] ingredientIds)
        //{
        //    return _databaseContext.Ingredient.Select(x => new IngredientDM{
        //            Id = x.Id,
        //            IngredientName = x.IngredientName,
        //            IngredientTypeId = x.IngredientTypeId
        //    }).ToList();
        //}

        public void GetDishesByCategoryId(int categoryId)
        {

        }

        public void GetDishById(int categoryId)
        {

        }


        //public async Task<RestaurantDM> GetRestaurant(int restaurantId)
        //{
        //    var restaurant = await _databaseContext.Restaurant.FirstOrDefaultAsync(x => x.Id == restaurantId);

        //    return BuildRestaurantDM(restaurant);
        //}

        //private RestaurantDM BuildRestaurantDM(tblRestaurant restaurant)
        //{
        //    if (restaurant == null)
        //        return null;

        //    return new RestaurantDM
        //    {
        //        Id = restaurant.Id,
        //        RestaurantName = restaurant.RestaurantName,
        //         RestaurantAlias = restaurant.RestaurantAlias
        //    };
        //}
    }
}
