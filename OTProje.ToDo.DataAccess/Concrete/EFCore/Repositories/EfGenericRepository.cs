using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OTProje.ToDo.DataAccess.Interfaces;
using OTProje.ToDo.Entities.Interface;

namespace OTProje.ToDo.DataAccess.Concrete.EFCore.Repositories
{
    public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity : class, ITable, new()
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }
    }
}