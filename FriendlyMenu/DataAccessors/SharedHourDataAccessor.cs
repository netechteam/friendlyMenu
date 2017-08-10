using Interfaces.DataAccessors;
using System;
using System.Collections.Generic;
using System.Text;
using DataModels;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;
using DbModels;

namespace DataAccessors
{
    public class SharedHourDataAccessor : ISharedHourDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public SharedHourDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<SharedHourDM> GetSharedHour(int sharedHourId)
        {
            var sharedHour = await _databaseContext.SharedHour.FirstOrDefaultAsync(x => x.Id == sharedHourId);
            return BuildSharedHourDM(sharedHour);

        }

        private SharedHourDM BuildSharedHourDM(tblSharedHour sharedHour)
        {
            if (sharedHour == null)
                return null;

            return new SharedHourDM
            {
                Id = sharedHour.Id,
                CloseTime = sharedHour.CloseTime,
                OpenTime = sharedHour.OpenTime,
                DayOfWeek = sharedHour.DayOfWeek
            };
        }
    }
}
