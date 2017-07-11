using DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Interfaces.DataAccessors
{
    public interface IAddressDataAccessor
    {
        Task<AddressDM> GetAddress(int restaurantId);
    }
}
