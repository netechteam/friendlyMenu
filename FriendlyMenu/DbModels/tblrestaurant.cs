using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblrestaurant")]
    public class tblRestaurant
    {
        [Column("restaurant_ix")]
        public int Id { get; set; }
        [Column("restaurantname_s")]
        public string RestaurantName { get; set; }
    }
}
