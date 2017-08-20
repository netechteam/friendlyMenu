using DbModels;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<tblRestaurant> Restaurant { get; set; }
        public DbSet<tblAddress> Address { get; set; }
        public DbSet<tblDish> Dish { get; set; }
        public DbSet<tblDishIngredients> DishIngredients { get; set; }
        public DbSet<tblIngredient> Ingredient { get; set; }
        public DbSet<tblIngredienttype> IngredientType { get; set; }
        public DbSet<tblCategory> Category { get; set; }
        public DbSet<tblSharedHour> SharedHour { get; set; }
        public DbSet<tblRestaurantContact> RestaurantContact { get; set; }
        public DbSet<tblRestaurantHour> RestaurantHour { get; set; }
    }
}
