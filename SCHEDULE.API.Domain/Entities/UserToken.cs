using System;

namespace SCHEDULE.API.Domain.Entities {
    public class UserToken {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
