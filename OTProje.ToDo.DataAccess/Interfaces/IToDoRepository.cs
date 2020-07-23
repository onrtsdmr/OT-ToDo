using System.Collections.Generic;
using OTProje.ToDo.Entities.Concrete;

namespace OTProje.ToDo.DataAccess.Interfaces
{
    public interface IToDoRepository : IGenericRepository<Entities.Concrete.ToDo>
    {
    }
}