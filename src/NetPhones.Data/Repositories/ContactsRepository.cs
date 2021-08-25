using Microsoft.EntityFrameworkCore;
using NetPhones.Core.Contracts.Repositories;
using NetPhones.Core.Entities;
using NetPhones.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Data.Repositories
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly NetPhonesContext _context;

        public ContactsRepository(NetPhonesContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            _context.Contacts.Update(contact);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Contact contact)
        {
            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
        }

        public async Task<Contact> FindAsync(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }

        public async Task<ICollection<Contact>> GetAllAsync()
        {
            return await _context.Contacts
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
