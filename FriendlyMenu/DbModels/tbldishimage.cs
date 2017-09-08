using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbModels
{
    [Table("dishimage")]
    public class tblDishImage
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("imageid")]
        public int ImageId { get; set; }
        [Column("dishid")]
        public int DishId { get; set; }
        [Column("imagelocation")]
        public string ImageLocation { get; set; }
        [Column("imagesizeid")]
        public int ImageSizeId { get; set; }
        [Column("imageposition")]
        public string ImagePosition { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
    }
}
