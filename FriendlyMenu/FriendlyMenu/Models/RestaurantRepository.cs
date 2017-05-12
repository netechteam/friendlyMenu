using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendlyMenu.Data;

namespace FriendlyMenu.Models
{
    public class RestaurantRepository
    {
        private readonly DatabaseContext _databaseContext;
        public RestaurantRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }
        public Restaurant GetRestaurant(int restaurantId)
        {
            return _databaseContext.Restaurants.SingleOrDefault(x => x.Id == restaurantId);
        }
    }
}
