using System;
using System.Threading.Tasks;
using DataModels;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using ViewModels;

namespace Managers
{
    public class RestaurantManager : IRestaurantManager
    {
        private readonly IRestaurantDataAccessor _restaurantDataAccessor;

        public RestaurantManager(IRestaurantDataAccessor restaurantDataAccessor)
        {
            _restaurantDataAccessor = restaurantDataAccessor;
        }

        public async Task<RestaurantVM> GetRestaurant(int restaurantId)
        {
            var dataModel =  await _restaurantDataAccessor.GetRestaurant(restaurantId);

            return BuildRestaurantVM(dataModel);
        }

        private RestaurantVM BuildRestaurantVM(RestaurantDM dataModel)
        {
            if (dataModel == null)
                return null;

            return new RestaurantVM
            {
                Id = dataModel.Id,
                RestaurantName = dataModel.RestaurantName
            };
        }
    }
}
