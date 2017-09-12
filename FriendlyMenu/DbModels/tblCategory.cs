using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("category")]
    public class tblCategory
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("categoryname")]
        public string CategoryName { get; set; }
    }
}
