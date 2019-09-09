using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UOW.Model;

namespace UOW.Sevice
{
     public interface IArticleService
    {
        Task AddArticle(ArticleModel article);

        Task AddArticleTransaction(ArticleModel article);

        Task AddArticleTransactionWithAnotherTable(ArticleModel article);
        IEnumerable<ArticleModel> Get();
    }
}
