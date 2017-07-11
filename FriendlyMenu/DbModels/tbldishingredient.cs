using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("dishingredient")]
    public class tbldishingredient
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("dishid")]
        public int DishId { get; set; }
        [Column("ingredientid")]
        public int IngredientId { get; set; }
    }
}
