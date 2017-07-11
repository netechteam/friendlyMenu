using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("menucategory")]
    public class tblMenuCategory
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("categoryname")]
        public string CategoryName { get; set; }
    }
}
