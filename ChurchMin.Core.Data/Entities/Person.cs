using Finbuckle.MultiTenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Entities
{
    public class Person : BaseEntity
    {
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
        public Person? EmergencyContact { get; set; }
        public ICollection<EmailAddress>? EmailAddresses { get; set; }
        public ICollection<PhoneNumber>? PhoneNumbers { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public Guid? FamilyId { get; set; }
        public Family? Family { get; set; }

        public ICollection<Ministry> Ministries { get; set; }
    }
}
