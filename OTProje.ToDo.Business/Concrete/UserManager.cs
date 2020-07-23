using OTProje.ToDo.Business.Interfaces;
using OTProje.ToDo.DataAccess.Interfaces;
using OTProje.ToDo.Entities.Concrete;

namespace OTProje.ToDo.Business.Concrete
{
    public class UserManager: GenericManager<User>
    {
        public UserManager(IGenericDal<User> genericDal) : base(genericDal)
        {
        }
    }
}