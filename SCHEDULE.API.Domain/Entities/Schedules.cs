using System;

namespace SCHEDULE.API.Domain.Entities {
    public class Schedules {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan TimeClasses { get; set; }
    }
}
