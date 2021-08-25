using Microsoft.EntityFrameworkCore;
using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Data.Context
{
    public class NetPhonesContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public NetPhonesContext(DbContextOptions<NetPhonesContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
