namespace Messages;

public class Contact

{

        public ChangeType ChangeType { get; set; } = ChangeType.Update;
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public Company AssociatedCustomer { get; set; } = new Company();
}
