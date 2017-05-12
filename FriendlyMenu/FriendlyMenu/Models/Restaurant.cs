using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FriendlyMenu.Models
{
    [Table("restaurant")]
    public class Restaurant
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantname")]
        public string RestaurantName { get; set; }
    }
}
