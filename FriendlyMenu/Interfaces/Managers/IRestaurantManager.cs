using DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Interfaces.Managers
{
    public interface IRestaurantManager
    {
        Task<RestaurantVM> GetRestaurant(int restaurantId);
        Task<List<DishVM>> GetAllDishes(int restaurantId);
        //Task AddDishIngredientArray(DishIngredientDM dishIngredientArray);
    }
}
