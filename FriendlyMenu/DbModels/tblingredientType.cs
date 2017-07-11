using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("ingredienttype")]
    public class tblingredienttype
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("typename")]
        public string TypeName{ get; set; }
    }
}
