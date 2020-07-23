using System.Collections.Generic;
using OTProje.ToDo.Entities.Interface;

namespace OTProje.ToDo.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity: class, ITable, new()
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}