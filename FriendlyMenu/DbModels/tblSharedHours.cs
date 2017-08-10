using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("sharedhour")]
    public class tblSharedHour
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("opentime")]
        public DateTime OpenTime { get; set; }
        [Column("closetime")]
        public DateTime CloseTime { get; set; }
        [Column("dayofweek")]
        public string DayOfWeek { get; set; }

    }
}
