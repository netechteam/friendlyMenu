using System;

namespace DataModels
{
    public class SharedHour 
    {
        public int Id { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string DayOfWeek { get; set; }
    }
}
