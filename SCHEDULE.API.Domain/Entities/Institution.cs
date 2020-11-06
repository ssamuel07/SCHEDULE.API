namespace SCHEDULE.API.Domain.Entities {
    public class Institution : Base {
        public string Description { get; set; }
        public Address Address { get; set; }
        public Status Status { get; set; }
    }
}
