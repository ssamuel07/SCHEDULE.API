using System;

namespace SCHEDULE.API.Domain.Entities {
    public class UserInfo : Person {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
