namespace Messages;

public class Company

{
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string Address3 { get; set; } = string.Empty;
        public ChangeType ChangeType { get; set; } = ChangeType.Update;
        public Guid CustomerId { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string CustomerType { get; set; } = string.Empty;
        public string CustomerUrl { get; set; } = string.Empty;
        public DateTime RelationshipEstablishedDate { get; set; }
        public string ISOCountry { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;

}
