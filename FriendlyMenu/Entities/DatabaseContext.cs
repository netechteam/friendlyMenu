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
        public DbSet<tblDishIngredient> DishIngredient { get; set; }
        public DbSet<tblIngredienttype> IngredientType { get; set; }
        public DbSet<tblMenuCategory> MenuCategory { get; set; }
    }
}
