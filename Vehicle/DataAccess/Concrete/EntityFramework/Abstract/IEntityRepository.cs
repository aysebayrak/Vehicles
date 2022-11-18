using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Abstract
{
    public interface IEntityRepository<T> where T : class , new()
    {
        List<T> GetAll(Expression<Func<T , bool>> filtet = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void UpDate(T entity);
        void Delete(T entity);  

    }
}
