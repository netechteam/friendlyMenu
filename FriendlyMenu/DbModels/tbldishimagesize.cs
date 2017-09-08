using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbModels
{
    [Table("dishimagesize")]
    public class tblDishImageSize
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("imageid")]
        public int ImageId { get; set; }
        [Column("height")]
        public int Height { get; set; }
        [Column("width")]
        public int Width { get; set; }
        [Column("sizename")]
        public int SizeName { get; set; }
    }
}
