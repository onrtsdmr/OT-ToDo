using OTProje.ToDo.DataAccess.Concrete.EFCore.Contexts;
using OTProje.ToDo.DataAccess.Interfaces;
using OTProje.ToDo.Entities.Concrete;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User, ToDoContext>, IUserDal
    {
    }
}