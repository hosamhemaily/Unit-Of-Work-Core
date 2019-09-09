using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL.Models;

namespace UOW.Repository
{
    public interface IRepository<T> where T : class
    {
        GoldhayAdminContext Context { get; }
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
