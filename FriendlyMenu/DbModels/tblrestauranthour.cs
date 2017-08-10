using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("restauranthour")]
    public class tblRestaurantHour
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantid")]
        public int RestaurantId { get; set; }
        [Column("sharedhourid")]
        public int SharedHourId{ get; set; }
    }
}
