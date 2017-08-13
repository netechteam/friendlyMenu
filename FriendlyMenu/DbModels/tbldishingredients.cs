using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dishingredients")]
    public class tblDishIngredients
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("dishid")]
        public int DishId{ get; set; }
        [Column("ingredientidlist")]
        public int[] IngredientIds { get; set; }
    }
}
