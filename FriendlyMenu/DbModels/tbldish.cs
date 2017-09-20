using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dish")]
    public class tblDish
    {
        //public tbldish()
        //{
        //    this.tblingredients = new HashSet<tblIngredient>();
        //}

        [Key]
        [Column("ixdish")]
        public int ixDish { get; set; }
        [Column("restaurantid")]
        public int restaurantId { get; set; }
        [Column("dishname")]
        public string DishName { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("categoryid")]
        public int ixCategoryId { get; set; }
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

        //public virtual ICollection<tblIngredient> tblingredients { get; set; }
        public virtual ICollection<tblDishIngredient> dishIngredients { get; set; }
        public virtual ICollection<tblDishImage> dishImages { get; set; }
    }
}
