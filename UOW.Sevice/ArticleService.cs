using System;
using System.Collections.Generic;
using System.Text;
using UOW.DAL.Models;
using UOW.Model;
using UOW.Repository;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace UOW.Sevice
{
    public class ArticleService : BaseService,IArticleService
    {
        public ArticleService(IUnitOfWork _unitOfWork) :base(_unitOfWork)
        { 
            
        }

        public async Task AddArticleFlat(ArticleModel article)
        {           
            await  _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name });
            await _unitOfWork.SaveChangesAsync();
            
        }

        public async Task AddArticleTransaction(ArticleModel article)
        {           
            await _unitOfWork.BeginTransaction();
            await _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name });                
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.CommitTransaction();
        }

        public async Task AddArticleTransactionWithAnotherTable(ArticleModel article)
        {
            await _unitOfWork.BeginTransaction();            
            var resultCategory = await _unitOfWork.GetRepository<Categories>().Add(new Categories { CategoryName = "test" });
            await _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name,CategoryId=resultCategory.CategoryId});            
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.CommitTransaction(); 
        }

        public async Task<ArticleModel> GetById(int id)
        {
           var result = await _unitOfWork.GetRepository<Articles>().GetById(id);
            return new ArticleModel { Name = result.Title };
        }

        public IEnumerable<ArticleModel> GetData(ArticleFilter articleFilter)
        {
            var query = GetWithFilter(articleFilter);
            var dataWithPaging =  GetWithPaging(articleFilter, query);
            return dataWithPaging.Select(x => new ArticleModel { Name = x.Name });

        }

        private IQueryable<Articles> GetWithFilter(ArticleFilter articleFilter)
        {
            var repository = _unitOfWork.GetRepository<Articles>();
            IQueryable<Articles> query=repository.GetWithFilter();

            if (articleFilter.id !=0)
            {
                query = repository.GetWithFilter((x => x.ArticleId == articleFilter.id));
            }
            
            else if (articleFilter.name != "")
            {
                query = query.Where(x => x.Title == articleFilter.name);
            }

            return query;            
        }

        private IEnumerable<ArticleModel> GetWithPaging(ArticleFilter articleFilter, IQueryable<Articles> query)
        {
            _unitOfWork.GetRepository<Articles>().GetWithPaging(articleFilter.PageIndex,articleFilter.PageSize,
                0 ,query);
            return query.Select(x => new ArticleModel { Name = x.Title }).ToList();
        }
    }
}
