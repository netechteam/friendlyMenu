using DbModels;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<tblRestaurant> tblRestaurants { get; set; }
        public DbSet<tblDish> tblDishes { get; set; }
        public DbSet<tblDishIngredient> tblDishIngredients { get; set; }
        public DbSet<tblIngredient> tblIngredients { get; set; }




        public DbSet<tblAddress> Address { get; set; }
        public DbSet<tblIngredienttype> IngredientType { get; set; }
        public DbSet<tblCategory> tblcategories { get; set; }
        public DbSet<tblSharedHour> SharedHour { get; set; }
        public DbSet<tblRestaurantContact> RestaurantContact { get; set; }
        public DbSet<tblRestaurantHour> RestaurantHour { get; set; }
        public DbSet<tblDishImageSize> DishImageSize { get; set; }
        public DbSet<tblDishImage> DishImage { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //
            modelBuilder.Entity<tblDishIngredient>()
                .HasKey(di => new { ixDishId = di.ixDish, ixIngredientId = di.ixIngredient });

            modelBuilder.Entity<tblDishIngredient>()
                .HasOne(di => di.tblDish)
                .WithMany(i => i.dishIngredients)
                .HasForeignKey(di => di.ixDish);

            modelBuilder.Entity<tblDishIngredient>()
                .HasOne(di => di.tblIngredient)
                .WithMany(c => c.dishIngredients)
                .HasForeignKey(di => di.ixIngredient);

            //
            //modelBuilder.Entity<tblDishImage>()
            //    .HasOne(x => x.tbldish)
            //    .WithMany(x => x.dishImages)
            //    .HasForeignKey(x => x.ixdish);

        }
    }
}
