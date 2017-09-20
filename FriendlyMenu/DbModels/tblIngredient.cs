using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("ingredient")]
    public class tblIngredient
    {
        [Key]
        [Column("ixingredient")]
        public int ixIngredient { get; set; }
        [Column("ingredienttypeid")]
        public int ixIngredientTypeId { get; set; }
        [Column("ingredientname")]
        public string sIngredientName { get; set; }

        //public virtual ICollection<tbldish> tbldishes { get; set; }
        public virtual ICollection<tblDishIngredient> dishIngredients { get; set; }

    }
}
