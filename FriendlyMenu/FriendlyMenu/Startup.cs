using DataAccessors;
using Entities;
using Interfaces.DataAccessors;
using Interfaces.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using Managers;
using Misc;

namespace FriendlyMenu
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            /* CODE TO EXTERNALIZE APPSETTINGS.JSON */

            //var absolutepath = System.IO.Path.GetFullPath("../../");
            //Configuration = new ConfigurationBuilder()
            //    .SetBasePath(absolutepath)
            //    .AddJsonFile($"global.json", optional: true, reloadOnChange: true).Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Managers
            //services.AddScoped<IRestaurantManager, RestaurantManager>();

            // DataAccessors
            services.AddScoped<IRestaurantDataAccessor, RestaurantDataAccessor>();
            //services.AddScoped<IAddressDataAccessor, AddressDataAccessor>();
            //services.AddScoped<IDishDataAccessor, DishDataAccessor>();
            //services.AddScoped<IDishIngredientDataAccessor, DishIngredientDataAccessor>();
            // Services

            // Add framework services.
            services.AddMvc();

            services.AddMultitenancy<AppTenant, AppTenantResolver>();
            services.Configure<MultitenancyOptions>(Configuration.GetSection("Multitenancy"));

            var connectionString = Configuration["DbContextSettings:ConnectionString"];
            services.AddDbContext<DatabaseContext>(opts => opts.UseNpgsql(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMultitenancy<AppTenant>();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
