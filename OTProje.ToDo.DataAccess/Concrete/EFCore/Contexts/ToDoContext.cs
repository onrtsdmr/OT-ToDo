using Microsoft.EntityFrameworkCore;
using OTProje.ToDo.DataAccess.Concrete.EFCore.Mapping;
using OTProje.ToDo.Entities.Concrete;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Contexts
{
    public class ToDoContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Entities.Concrete.ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;port=3306;database=ToDoApp;user=root;password=onur123123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new ToDoMap());
        }
    }
}