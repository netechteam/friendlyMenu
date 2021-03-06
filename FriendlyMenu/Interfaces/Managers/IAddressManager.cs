﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Interfaces.Managers
{
    public interface IAddressManager
    {
        Task<AddressVM> GetAddress(int restaurantId);
    }
}
