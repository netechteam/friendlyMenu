using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Misc;
using SaasKit.Multitenancy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendlyMenu
{
    public class AppTenantResolver : ITenantResolver<AppTenant>
    {
        //IEnumerable<AppTenant> tenants = new List<AppTenant>(new[]
        //{
        //    new AppTenant {
        //        Name = "China Wall",
        //        RestaurantId = 1,
        //        Hostnames = new[] { "localhost:5000", "localhost:5001" }
        //    },
        //    new AppTenant {
        //        Name = "Tenant 2",
        //        RestaurantId = 2,
        //        Hostnames = new[] { "localhost:6000" }
        //    }
        //});

        private readonly IEnumerable<AppTenant> tenants;

        public AppTenantResolver(IOptions<MultitenancyOptions> options)
        {
            this.tenants = options.Value.Tenants;
        }

        public async Task<TenantContext<AppTenant>> ResolveAsync(HttpContext context)
        {
            TenantContext<AppTenant> tenantContext = null;

            var tenant = tenants.FirstOrDefault(t =>
                t.Hostnames.Any(h => h.Equals(context.Request.Host.Value.ToLower())));

            if (tenant != null)
            {
                tenantContext = new TenantContext<AppTenant>(tenant);
            }

            return tenantContext;
        }
    }
}
