using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tbldish")]
    public class tblDish
    {
        //public tbldish()
        //{
        //    this.tblingredients = new HashSet<tblIngredient>();
        //}

        [Key]
        [Column("dish_ix")]
        public int ixDish { get; set; }
        [Column("restaurant_ix")]
        public int restaurantId { get; set; }
        [Column("dishname_s")]
        public string DishName { get; set; }
        [Column("description_s")]
        public string Description { get; set; }
        [Column("category_ix")]
        public int ixCategoryId { get; set; }
        [Column("pricebreakfast_dbl")]
        public double PriceBreakfast { get; set; }
        [Column("pricelunch_dbl")]
        public double PriceLunch { get; set; }
        [Column("pricecombo_dbl")]
        public double PriceCombo { get; set; }
        [Column("pricedinner_dbl")]
        public double PriceDinner { get; set; }
        [Column("isbreakfast_b")]
        public bool IsBreakfast { get; set; }
        [Column("islunch_b")]
        public bool IsLunch { get; set; }
        [Column("iscombo_b")]
        public bool IsCombo { get; set; }
        [Column("isspicy_b")]
        public bool IsSpicy{ get; set; }
        [Column("isfeatured_b")]
        public bool IsFeatured { get; set; }

        //public virtual ICollection<tblIngredient> tblingredients { get; set; }
        public virtual ICollection<tblDishIngredient> dishIngredients { get; set; }
        public virtual ICollection<tblDishImage> dishImages { get; set; }
    }
}
