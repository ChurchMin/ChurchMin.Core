using ChurchMin.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchMin.Core.Data.Repository
{
    public interface ICoreRepository
    {
        Task<List<Address>> GetAllAddressesAsync();
        Task<Address> GetAddressAsync(Guid id);
        Task<bool> AddAdressAsync(Address address);
        Task<bool> DeleteAdressAsync(Address address);
        Task<bool> AddressDoesExistAsync(Guid id);

        Task<List<EmailAddress>> GetAllEmailAddressesAsync();
        Task<EmailAddress> GetEmailAddressAsync(Guid id);
        Task<bool> AddEmailAdressAsync(EmailAddress emailAddress);
        Task<bool> DeleteEmailAdressAsync(EmailAddress emailAddress);
        Task<bool> EmailAddressDoesExistAsync(Guid id);

        Task<List<PhoneNumber>> GetAllPhoneNumbersAsync();
        Task<PhoneNumber> GetPhoneNumberAsync(Guid id);
        Task<bool> AddPhoneNumberAsync(PhoneNumber phoneNumber);
        Task<bool> DeletePhoneNumberAsync(PhoneNumber phoneNumber);
        Task<bool> PhoneNumberDoesExistAsync(Guid id);

        Task<List<Family>> GetAllFamiliesAsync();
        Task<Family> GetFamilyAsync(Guid id);
        Task<bool> AddFamilyAsync(Family family);
        Task<bool> DeleteFamilyAsync(PhoneNumber family);
        Task<bool> FamilyDoesExistAsync(Guid id);

        Task<List<Ministry>> GetAllMinistriesAsync();
        Task<Ministry> GetMinistryAsync(Guid id);
        Task<bool> AddMinistryAsync(Ministry ministry);
        Task<bool> DeleteMinistryAsync(Ministry ministry);
        Task<bool> MinistryDoesExistAsync(Guid id);

        Task<List<Person>> GetAllPeopleAsync();
        Task<Person> GetPersonAsync(Guid id);
        Task<bool> AddPersonAsync(Person person);
        Task<bool> DeletePersonAsync(Person person);
        Task<bool> PersonDoesExistAsync(Guid id);
    }
}
