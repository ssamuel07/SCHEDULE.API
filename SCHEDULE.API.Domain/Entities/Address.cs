namespace SCHEDULE.API.Domain.Entities {
    public class Address : Base {
        public string Postcode { get; set; }
        public City City { get; set; }
    }
}
