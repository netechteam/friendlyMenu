using System;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DbModels;
using Entities;
using Interfaces.DataAccessors;
using Microsoft.EntityFrameworkCore;

namespace DataAccessors
{
    public class RestaurantDataAccessor : IRestaurantDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public RestaurantDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<RestaurantDM> GetRestaurant(int restaurantId)
        {
            var restaurant = await _databaseContext.Restaurants.FirstOrDefaultAsync(x => x.Id == restaurantId);

            return BuildRestaurantDM(restaurant);
        }

        private RestaurantDM BuildRestaurantDM(tblrestaurant restaurant)
        {
            if (restaurant == null)
                return null;

            return new RestaurantDM
            {
                Id = restaurant.Id,
                RestaurantName = restaurant.RestaurantName
            };
        }
    }
}
