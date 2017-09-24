using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblingredient")]
    public class tblIngredient
    {
        [Key]
        [Column("ingredient_ix")]
        public int ixIngredient { get; set; }
        [Column("ingredienttype_ix")]
        public int ixIngredientTypeId { get; set; }
        [Column("ingredientname_s")]
        public string sIngredientName { get; set; }

        //public virtual ICollection<tbldish> tbldishes { get; set; }
        public virtual ICollection<tblDishIngredient> dishIngredients { get; set; }

    }
}
