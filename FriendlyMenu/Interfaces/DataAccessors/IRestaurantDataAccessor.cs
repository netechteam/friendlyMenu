using DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Interfaces.DataAccessors
{
    public interface IRestaurantDataAccessor
    {
        //Task<RestaurantDM> GetRestaurant(int restaurantId);
        Task<List<DishDM>>GetAllDishes(int restaurantId);
        void GetDishesByCategoryId(int categoryId);
        void GetDishById(int dishId);
    }

}
