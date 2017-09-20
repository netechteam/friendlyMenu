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
        Task<CategoryPageVM> GetDishesByCategory(int categoryId, int restaurantId);
        
    }
}
