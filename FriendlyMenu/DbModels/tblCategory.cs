using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("category")]
    public class tblCategory
    {
        [Key]
        [Column("id")]
        public int ixCategoryId { get; set; }
        [Column("categoryname")]
        public string sCategoryName { get; set; }
    }
}
