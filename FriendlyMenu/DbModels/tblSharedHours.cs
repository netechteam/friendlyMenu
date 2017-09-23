using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbModels
{
    [Table("tblsharedhour")]
    public class tblSharedHour
    {
        [Column("sharedhour_ix")]
        public int Id { get; set; }
        [Column("opentime_tm")]
        public DateTime OpenTime { get; set; }
        [Column("closetime_tm")]
        public DateTime CloseTime { get; set; }
        [Column("dayofweek_s")]
        public string DayOfWeek { get; set; }

    }
}
