using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL.Models;

namespace UOW.Repository
{
    public interface IRepository<T> where T : class
    {
        GoldhayAdminContext Context { get; }
        IQueryable<T> GetWithFilter(Expression<Func<T, bool>> predicate=null);
        IQueryable<T> GetWithPaging(int PageIndex, int PageSize, int PageCount, IQueryable<T> query);
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
