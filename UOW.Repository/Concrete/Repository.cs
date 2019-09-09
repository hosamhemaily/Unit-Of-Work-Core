using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL.Models;

namespace UOW.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public GoldhayAdminContext Context { get; set; }

        //GoldhayAdminContext IRepository<T>.Context => throw new NotImplementedException();

        protected DbSet<T> DbSet;
        public Repository(GoldhayAdminContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
            var result = await Context.AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            Context.Remove(entity);
        }

        public IEnumerable<T> Get()
        {
            return Context.Set<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).AsEnumerable();
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<T>().Attach(entity);
        }
    }
}
