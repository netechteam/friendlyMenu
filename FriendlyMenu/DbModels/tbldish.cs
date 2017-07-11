using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dish")]
    public class tbldish
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantid")]
        public int RestaurantId { get; set; }
        [Column("menucategoryid")]
        public int MenuCategoryId { get; set; }
        [Column("dishname")]
        public string DishName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public double Price { get; set; }
    }
}
