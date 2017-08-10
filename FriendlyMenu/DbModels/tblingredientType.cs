using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("ingredienttype")]
    public class tblIngredienttype
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ingredienttypename")]
        public string IngredientTypeName{ get; set; }
    }
}
