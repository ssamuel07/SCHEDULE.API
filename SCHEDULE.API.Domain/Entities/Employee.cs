using System.Collections.Generic;

namespace SCHEDULE.API.Domain.Entities {
    public class Employee : Person {
        public Institution Institution { get; set; }
        public Subjects Subjects { get; set; }
        public List<Schedules> FreeSchedules { get; set; }
    }
}
