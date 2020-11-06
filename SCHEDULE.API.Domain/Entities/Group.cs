using System.Collections.Generic;

namespace SCHEDULE.API.Domain.Entities {
    public class Group : Base {
        public List<Employee> Employee { get; set; }
    }
}
