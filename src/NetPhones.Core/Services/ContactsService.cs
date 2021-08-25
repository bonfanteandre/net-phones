using NetPhones.Core.Contracts.Repositories;
using NetPhones.Core.Contracts.Services;
using NetPhones.Core.Entities;
using NetPhones.Core.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Core.Services
{
    public class ContactsService : ServiceBase<Contact>, IContactsService
    {
        private readonly IContactsRepository _contactsRepository;

        public ContactsService(IContactsRepository contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public async Task AddAsync(Contact contact)
        {
            if (!ExecuteValidation(new ContactValidator(), contact))
            {
                return;
            }

            await _contactsRepository.AddAsync(contact);
        }

        public async Task UpdateAsync(int id, Contact contact)
        {
            var contactToUpdate = await _contactsRepository.FindAsync(id);

            if (contact == null)
            {
                AddError("Contact not found");
                return;
            }

            if (!ExecuteValidation(new ContactValidator(), contact))
            {
                return;
            }

            contactToUpdate.FirstName = contact.FirstName;
            contactToUpdate.LastName = contact.LastName;
            contactToUpdate.PhoneNumber = contact.PhoneNumber;

            await _contactsRepository.UpdateAsync(contact);
        }

        public async Task RemoveAsync(int id)
        {
            var contact = await _contactsRepository.FindAsync(id);

            if (contact == null)
            {
                AddError("Contact not found");
                return;
            }

            await _contactsRepository.RemoveAsync(contact);
        }

        public async Task<Contact> FindAsync(int id)
        {
            return await _contactsRepository.FindAsync(id);
        }

        public async Task<ICollection<Contact>> GetAllAsync()
        {
            return await _contactsRepository.GetAllAsync();
        }
    }
}
