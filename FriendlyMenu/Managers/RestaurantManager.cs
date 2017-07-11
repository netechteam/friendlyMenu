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
        private readonly IAddressDataAccessor _addressDataAccessor;

        public RestaurantManager(IRestaurantDataAccessor restaurantDataAccessor, IAddressDataAccessor addressDataAccessor)
        {
            _restaurantDataAccessor = restaurantDataAccessor;
            _addressDataAccessor = addressDataAccessor;
        }

        public async Task<RestaurantVM> GetRestaurant(int restaurantId)
        {
            var restaurantDataModel  =  await _restaurantDataAccessor.GetRestaurant(restaurantId);
            var addressDataModel = await _addressDataAccessor.GetAddress(restaurantId);
            var addressVM = BuildAddressVM(addressDataModel);

            return BuildRestaurantVM(restaurantDataModel);
        }

        private AddressVM BuildAddressVM(AddressDM dataModel)
        {
            if (dataModel == null)
                return null;

            return new AddressVM
            {
                Id = dataModel.Id,
                RestaurantId = dataModel.RestaurantId,
                StreetName = dataModel.StreetName,
                CityName = dataModel.CityName,
                StateName = dataModel.StateName,
                StateAbbr = dataModel.StateAbbr,
                Zip = dataModel.Zip,
                Country = dataModel.Country,
                CountryAbbr = dataModel.CountryAbbr
            };
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
