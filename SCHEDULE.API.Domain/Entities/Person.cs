namespace SCHEDULE.API.Domain.Entities {
    public class Person : Base {
        public string CPF { get; set; }
        public string RG { get; set; }
        public Address Address { get; set; }
        public int AddressNumber { get; set; }
        public string Complement { get; set; }

    }
}
