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
    public class AddressDataAccessor : IAddressDataAccessor
    {

        private readonly DatabaseContext _databaseContext;

        public AddressDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<AddressDM> GetAddress(int restaurantId)
        {
            var address = await _databaseContext.Address.FirstOrDefaultAsync(x => x.Id == restaurantId);

            return BuildAddressDM(address);
        }

        private AddressDM BuildAddressDM(tbladdress address)
        {
            if (address == null)
                return null;

            return new AddressDM
            {
                Id = address.Id,
                RestaurantId = address.RestaurantId,
                StreetName = address.StreetName,
                CityName = address.CityName,
                StateName = address.StateName,
                StateAbbr = address.StateAbbr,
                Zip = address.Zip,
                Country = address.Country,
                CountryAbbr = address.CountryAbbr
            };
        }
    }
}
