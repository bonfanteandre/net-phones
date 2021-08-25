using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Core.Contracts.Services
{
    public interface IContactsService
    {
        Task AddAsync(Contact contact);
        Task UpdateAsync(int id, Contact contact);
        Task RemoveAsync(int id);
        Task<Contact> FindAsync(int id);
        Task<ICollection<Contact>> GetAllAsync();
    }
}
