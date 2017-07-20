using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("restaurant")]
    public class tblRestaurant
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantname")]
        public string RestaurantName { get; set; }
        [Column("restaurantalias")]
        public string RestaurantAlias { get; set; }
    }
}
