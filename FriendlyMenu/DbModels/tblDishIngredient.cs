using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tbldishingredient")]
    public class tblDishIngredient
    {
        //[Key]
        //[Column("id")]
        //public int ixDishIngredientId { get; set; }
        [Column("dish_ix")]
        public int ixDish{ get; set; }
        [Column("ingredient_ix")]
        public int ixIngredient { get; set; }

        public tblDish tblDish { get; set; }
        public tblIngredient tblIngredient { get; set; }
    }
}
