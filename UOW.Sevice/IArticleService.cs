using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UOW.DAL.Models;
using UOW.Model;

namespace UOW.Sevice
{
     public interface IArticleService
    {
        Task AddArticleFlat(ArticleModel article);

        Task AddArticleTransaction(ArticleModel article);

        Task AddArticleTransactionWithAnotherTable(ArticleModel article);
        
        Task<IEnumerable<ArticleModel>> GetData(ArticleFilter articleFilter);

        Task<ArticleModel> GetById(int id);
    }
}
