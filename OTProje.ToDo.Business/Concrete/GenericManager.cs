using System.Collections.Generic;
using OTProje.ToDo.Business.Interfaces;
using OTProje.ToDo.DataAccess.Interfaces;
using OTProje.ToDo.Entities.Interface;

namespace OTProje.ToDo.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            this._genericDal = genericDal;
        }
        
        public void Create(TEntity entity)
        {
            _genericDal.Create(entity);
        }

        public void Delete(TEntity entity)
        {
            _genericDal.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            _genericDal.Update(entity);
        }

        public TEntity GetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public List<TEntity> GetAll()
        {
            return _genericDal.GetAll();
        }
    }
}