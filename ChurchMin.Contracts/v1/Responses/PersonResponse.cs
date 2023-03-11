
namespace ChurchMin.Contracts.v1.Responses
{
    public class PersonResponse
    {
        public required Guid Id { get; set; }
        public string? Title { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? PreferredName { get; set; }
        public string? Gender { get; set; }
        public string? MartialStatus { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? Anniversary { get; set; }
        public required string AdultChild { get; set; }
        public string? Grade { get; set; }
        public string? MedicalNotes { get; set; }
        public string? GeneralNotes { get; set; }
        public bool IsDoNotContact { get; set; }
        public Guid? EmergencyContactId { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNumber { get; set; }

        public ICollection<EmailResponse>? EmailAddresses { get; set; }
        public ICollection<PhoneResponse>? PhoneNumbers { get; set; }
        public ICollection<AddressResponse>? Addresses { get; set; }
        public Guid? FamilyId { get; set; }
    }
}
