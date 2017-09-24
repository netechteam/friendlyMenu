using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblrestauranthour")]
    public class tblRestaurantHour
    {
        [Column("restauranthour_ix")]
        public int Id { get; set; }
        [Column("restaurant_ix")]
        public int RestaurantId { get; set; }
        [Column("sharedhour_ix")]
        public int SharedHourId{ get; set; }
    }
}
