using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public IQueryable<T> GetWithFilter(Expression<Func<T, bool>> predicate=null)
        {            
            return  Context.Set<T>().Where(predicate).AsQueryable(); 
        }

        public IQueryable<T> GetWithPaging(int PageIndex, int PageSize, int PageCount,IQueryable<T> query)
        {
            if (PageSize == 0)
            {
                return query;
            }
            else
            {
                //var result = Context.Set<T>().Where(predicate).AsQueryable();
                int countForSkip = (PageIndex) * PageSize;
                var r2 = query.Skip(countForSkip).Take(PageSize);
                return r2;
            }

        }

        public async Task<T> GetById(int id)
        {
            var result = await Context.Set<T>().FindAsync(id);
            return result;
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<T>().Attach(entity);
        }

       
        
    }
}
