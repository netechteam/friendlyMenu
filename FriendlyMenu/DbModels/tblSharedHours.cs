using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("sharedhour")]
    public class tblSharedHour
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("openhour")]
        public DateTime openhour { get; set; }
        [Column("closehour")]
        public DateTime closehour { get; set; }
        [Column("dayofweek")]
        public DateTime DayOfWeek { get; set; }

    }
}
