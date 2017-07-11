using DbModels;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<tblrestaurant> Restaurant { get; set; }
        public DbSet<tbladdress> Address { get; set; }
        public DbSet<tbldish> Dish { get; set; }
    }
}
