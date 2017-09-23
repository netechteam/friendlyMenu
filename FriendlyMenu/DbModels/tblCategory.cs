using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblcategory")]
    public class tblCategory
    {
        [Key]
        [Column("category_ix")]
        public int ixCategoryId { get; set; }
        [Column("categoryname_s")]
        public string sCategoryName { get; set; }
        [Column("restaurant_ix")]
        public int RestaurantId{ get; set; }
    }
}
