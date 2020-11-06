using System.Collections.Generic;

namespace SCHEDULE.API.Domain.Entities {
    public class Curriculum : Base {
        public List<Group> Groups { get; set; }
        public List<Schedules> Schedules { get; set; }
    }
}
