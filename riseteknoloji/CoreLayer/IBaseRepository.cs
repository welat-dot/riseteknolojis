using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> GetList(Expression<Func<T, bool>>? filter = null);
        T Add(T Entity);
        T Update(T Entity);
        T Delete(T Entity);
    }
}
