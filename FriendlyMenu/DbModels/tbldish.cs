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
        [Column("categoryid")]
        public int CategoryId { get; set; }
        [Column("pricebreakfast")]
        public double PriceBreakfast { get; set; }
        [Column("pricelunch")]
        public double PriceLunch { get; set; }
        [Column("pricecombo")]
        public double PriceCombo { get; set; }
        [Column("pricedinner")]
        public double PriceDinner { get; set; }
        [Column("isbreakfast")]
        public bool IsBreakfast { get; set; }
        [Column("islunch")]
        public bool IsLunch { get; set; }
        [Column("iscombo")]
        public bool IsCombo { get; set; }
        [Column("isspicy")]
        public bool IsSpicy{ get; set; }
    }
}
