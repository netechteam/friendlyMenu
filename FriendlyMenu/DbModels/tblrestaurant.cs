using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("restaurant")]
    public class tblrestaurant
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantname")]
        public string RestaurantName { get; set; }
    }
}
