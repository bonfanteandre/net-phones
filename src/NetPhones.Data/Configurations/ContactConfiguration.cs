using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder
                .ToTable("Contacts");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(c => c.LastName)
                .HasMaxLength(50);

            builder
                .Property(c => c.PhoneNumber)
                .IsRequired()
                .HasMaxLength(14);
        }
    }
}
