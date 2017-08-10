using DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DataAccessors
{
    public interface ISharedHourDataAccessor
    {
        Task<SharedHourDM> GetSharedHour(int restaurantId);
    }
}
