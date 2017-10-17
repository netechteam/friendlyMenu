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
        Task<CategoryDishesDM> GetDishesByCategory(int categoryId, int restaurantId);
        //Task<CategoryDishesDM> GetDishesByCategory2(int categoryId, int restaurantId);

        //void GetDishesByCategoryId(int categoryId);
        //void GetDishById(int dishId);

        Task<HomePageDM> GetHomePageDm(int restaurantId);
    }

}
