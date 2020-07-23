using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OTProje.ToDo.Entities.Concrete;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseMySqlIdentityColumn();

            builder.Property(I => I.FirstName).HasMaxLength(45).IsRequired();
            builder.Property(I => I.LastName).HasMaxLength(45).IsRequired();
            builder.Property(I => I.PhoneNumber).HasMaxLength(12);
            builder.Property(I => I.Email).HasMaxLength(45).IsRequired();

            builder
                .HasMany(I => I.ToDos)
                .WithOne(I => I.User)
                .HasForeignKey(I => I.UserId);
        }
    }
}