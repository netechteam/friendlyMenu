using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbModels
{
    [Table("tbldishimage")]
    public class tblDishImage
    {
        [Key]
        [Column("dishimage_ix")]
        public int ixdishimage { get; set; }
        [Column("dish_ix")]
        public int ixdish { get; set; }
        [Column("imagelocation_s")]
        public string ImageLocation { get; set; }
        [Column("dishimagesize_ix")]
        public int ImageSizeId { get; set; }
        [Column("imageposition_i")]
        public string ImagePosition { get; set; }
        [Column("createdateutc_dt")]
        public DateTime CreateDate { get; set; }

        public tblDish tbldish{ get; set; }
    }
}
