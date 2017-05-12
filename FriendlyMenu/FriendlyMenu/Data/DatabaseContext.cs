using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendlyMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace FriendlyMenu.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
