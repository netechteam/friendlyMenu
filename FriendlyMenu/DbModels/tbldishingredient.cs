using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dishingredient")]
    public class tblDishIngredient
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("dishname")]
        public string DishName { get; set; }
        [Column("ingredientid")]
        //public int [] DishId { get; set; }
        public List<int> DishId { get; set; }
    }
}
