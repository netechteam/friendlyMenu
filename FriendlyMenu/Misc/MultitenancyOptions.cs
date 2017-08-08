using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Misc
{
    public class MultitenancyOptions
    {
        public Collection<AppTenant> Tenants { get; set; }
    }
}
