using System;
using System.Threading.Tasks;
using DataModels;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using ViewModels;

namespace Managers
{
    public class AddressManager : IAddressManager
    {
        private readonly IAddressDataAccessor _addressDataAccessor;

        public AddressManager(IAddressDataAccessor addressDataAccessor)
        {
            _addressDataAccessor = addressDataAccessor;
        }

        public async Task<AddressVM> GetAddress(int restaurantId)
        {
            var dataModel =  await _addressDataAccessor.GetAddress(restaurantId);

            return BuildAddressVM(dataModel);
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
    }
}
