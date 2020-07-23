using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Mapping
{
    public class ToDoMap : IEntityTypeConfiguration<Entities.Concrete.ToDo>
    {
        public void Configure(EntityTypeBuilder<Entities.Concrete.ToDo> builder)
        {
            // primary key
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseMySqlIdentityColumn();

            // 
            builder.Property(I => I.Name).HasMaxLength(45).IsRequired();
            builder.Property(I => I.Description).HasColumnType("text");

            builder
                .HasOne(I => I.User)
                .WithMany(I => I.ToDos)
                .HasForeignKey(I => I.Id);
        }
    }
}