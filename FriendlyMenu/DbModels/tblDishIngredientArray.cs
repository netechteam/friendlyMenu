using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dishingredientarray")]
    public class tblDishIngredientArray
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("dishname")]
        public string DishName { get; set; }
        [Column("ingredientid")]
        public int [] DishId { get; set; }
    }
}
