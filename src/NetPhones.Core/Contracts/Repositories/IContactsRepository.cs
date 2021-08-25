using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Core.Contracts.Repositories
{
    public interface IContactsRepository
    {
        Task AddAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task RemoveAsync(Contact contact);
        Task<Contact> FindAsync(int id);
        Task<ICollection<Contact>> GetAllAsync();
    }
}
