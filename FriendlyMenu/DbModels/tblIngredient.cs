using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("ingredient")]
    public class tblIngredient
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ingredienttypeid")]
        public int IngredientTypeId { get; set; }
        [Column("ingredientname")]
        public string IngredientName { get; set; }
    }
}
