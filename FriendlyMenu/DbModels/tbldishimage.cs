using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbModels
{
    [Table("dishimage")]
    public class tblDishImage
    {
        [Key]
        [Column("ixdishimage")]
        public int ixdishimage { get; set; }
        [Column("ixdish")]
        public int ixdish { get; set; }

        [Column("imagelocation")]
        public string ImageLocation { get; set; }
        [Column("imagesizeid")]
        public int ImageSizeId { get; set; }
        [Column("imageposition")]
        public string ImagePosition { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }

        public tblDish tbldish{ get; set; }
    }
}
