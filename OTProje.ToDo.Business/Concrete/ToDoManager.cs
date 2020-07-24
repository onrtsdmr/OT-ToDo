using OTProje.ToDo.Business.Interfaces;
using OTProje.ToDo.DataAccess.Interfaces;

namespace OTProje.ToDo.Business.Concrete
{
    public class ToDoManager : GenericManager<Entities.Concrete.ToDo>, IToDoService
    {
        public ToDoManager(IGenericDal<Entities.Concrete.ToDo> genericDal) : base(genericDal)
        {
        }
    }
}