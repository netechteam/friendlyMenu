using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dishingredients")]
    public class tblDishIngredient
    {
        //[Key]
        //[Column("id")]
        //public int ixDishIngredientId { get; set; }
        [Column("ixdish")]
        public int ixDish{ get; set; }
        [Column("ixingredient")]
        public int ixIngredient { get; set; }

        public tblDish tblDish { get; set; }
        public tblIngredient tblIngredient { get; set; }
    }
}
