using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dish")]
    public class tblDish
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("restaurantid")]
        public int RestaurantId { get; set; }
        [Column("dishname")]
        public string DishName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("menucategoryid")]
        public int [] MenuCategoryId { get; set; }
        [Column("pricelunch")]
        public double PriceLunch { get; set; }
        [Column("pricecombo")]
        public double PriceCombo { get; set; }
        [Column("pricedinner")]
        public double PriceDinner { get; set; }
        [Column("islunch")]
        public double IsLunch { get; set; }
        [Column("iscombo")]
        public double IsCombo { get; set; }
        [Column("isspicy")]
        public double IsSpicy{ get; set; }
    }
}
