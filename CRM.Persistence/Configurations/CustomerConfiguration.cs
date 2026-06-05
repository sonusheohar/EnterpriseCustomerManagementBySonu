using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(x => x.LastName)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(x => x.Email)
               .HasMaxLength(200)
               .IsRequired();

            builder.HasIndex(x => x.Email)
               .IsUnique();
        }
    }
}
