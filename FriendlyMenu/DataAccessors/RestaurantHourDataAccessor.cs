using Entities;
using Interfaces.DataAccessors;
using System;
using System.Collections.Generic;
using System.Text;
using DataModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbModels;

namespace DataAccessors
{
    class RestaurantHourDataAccessor : IRestaurantHourDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public RestaurantHourDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<RestaurantHourDM> GetRestaurantHour(int restaurantId)
        {
            var restaurantHour = await _databaseContext.RestaurantHour.FirstOrDefaultAsync(x => x.Id == restaurantId);
            return BuildRestaurantDM(restaurantHour);
        }

        private RestaurantHourDM BuildRestaurantDM(tblRestaurantHour restaurantHour)
        {
            if (restaurantHour == null)
                return null;
            
            return new RestaurantHourDM
            {
                Id = restaurantHour.Id,
                RestaurantId = restaurantHour.RestaurantId,
                SharedHourId = restaurantHour.SharedHourId
            };
        }
    }
}
