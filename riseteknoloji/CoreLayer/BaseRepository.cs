using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoreLayer
{
    public class BaseRepository<T,TContext>: IBaseRepository<T> where T : class, IEntity, new ()
        where TContext : DbContext, new()
    {

        private TContext Context;
        public BaseRepository(TContext Context)
        {
            
            this.Context = Context;
        }
        public T Add(T Entity)
        {

            var x = Context.Set<T>().Add(Entity);
            Context.SaveChanges();
            return x.Entity;
            
        }

        public T Delete(T Entity)
        {
            var x = Context.Set<T>().Remove(Entity);
            Context.SaveChanges();
            return x.Entity;

            
        }

        public T Get(Expression<Func<T, bool>> filter)
        {

            return Context.Set<T>().FirstOrDefault(filter);
            
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>>? filter = null)
        {
            { 
            if (filter == null)
                return Context.Set<T>();
            return Context.Set<T>().Where(filter);

            }
        }

        public T Update(T Entity)
        {
            //Context.Entry<T>(Entity).State = EntityState.Detached;
            var x = Context.Set<T>().Update(Entity);
            Context.SaveChanges();
            return x.Entity;
        }
    }
}
