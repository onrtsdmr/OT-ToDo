using OTProje.ToDo.DataAccess.Concrete.EFCore.Contexts;
using OTProje.ToDo.DataAccess.Interfaces;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Repositories
{
    public class EfToDoRepository : EfGenericRepository<Entities.Concrete.ToDo, ToDoContext>, IToDoDal
    {
    }
}