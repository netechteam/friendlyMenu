using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbModels
{
    [Table("tbldishimagesize")]
    public class tblDishImageSize
    {
        [Column("dishimagesize_ix")]
        public int Id { get; set; }
        [Column("dishimage_ix")]
        public int ImageId { get; set; }
        [Column("height_i")]
        public int Height { get; set; }
        [Column("width_i")]
        public int Width { get; set; }
        [Column("sizename_s")]
        public int SizeName { get; set; }
    }
}
