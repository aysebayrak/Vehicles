using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext ,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var eddedEntity = context.Entry(entity); //veri kaynağım ile ilişkilendirdim  referansı yakala 
                eddedEntity.State = EntityState.Added; //o eklenecek bir nesne
                context.SaveChanges(); //ve ekle 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void UpDate(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var apdatedEntity = context.Entry(entity);
                apdatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
