using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblingredienttype")]
    public class tblIngredienttype
    {
        [Column("ingredienttype_ix")]
        public int Id { get; set; }
        [Column("ingredienttypename_s")]
        public string IngredientTypeName{ get; set; }
    }
}
