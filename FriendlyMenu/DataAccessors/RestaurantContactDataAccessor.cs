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
    public class RestaurantContactDataAccessor : IRestaurantContactDataAccessor
    {
        private readonly DatabaseContext _databaseContext;
        public RestaurantContactDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<RestaurantContactDM> GetRestaurantContact(int restaurantId)
        {
            var contact = await _databaseContext.RestaurantContact.FirstOrDefaultAsync(x => x.Id == restaurantId);
            return BuildRestaurantContactDM(contact);
        }

        private RestaurantContactDM BuildRestaurantContactDM(tblRestaurantContact contact)
        {
            if (contact == null)
                return null;
            return new RestaurantContactDM
            {
                Id = contact.Id,
                StaffName = contact.StaffName,
                Email = contact.Email,
                Fax = contact.Fax,
                PhoneAlt = contact.PhoneAlt,
                PhoneMain = contact.PhoneMain,
                RestaurantId = contact.RestaurantId
            };
        }
    }
}
