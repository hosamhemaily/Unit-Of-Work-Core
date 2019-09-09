using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL.Models;

namespace UOW.Repository
{
    public interface IUnitOfWork
    {
        //IRepository<T> Repo { get; }
        //GoldhayAdminContext Context { get; }
        Task<int> SaveChangesAsync();

        IRepository<T> GetRepository<T>() where T : class;

        Task BeginTransaction();

        void CommitTransaction();
        void RollBackTransaction();

    }
}
