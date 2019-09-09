using System;
using System.Collections.Generic;
using System.Text;
using UOW.DAL.Models;
using UOW.Model;
using UOW.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace UOW.Sevice
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Articles> _repository;
        

        public ArticleService(IUnitOfWork unitOfWork, 
            IRepository<Articles> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            
        }

        public async Task AddArticle(ArticleModel article)
        {
            //using (var context = new GoldhayAdminContext())
            //{
                await _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name });
                //await _unitOfWork.art.Repo..Add(new Articles { Title = article.Name } );
                await _unitOfWork.SaveChangesAsync();
            //}

        }

        public async Task AddArticleTransaction(ArticleModel article)
        {
            //using (var context = new GoldhayAdminContext())
            //{
                await _unitOfWork.BeginTransaction();
                await _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name });
                //await _unitOfWork.art.Repo..Add(new Articles { Title = article.Name } );
                await _unitOfWork.SaveChangesAsync();
                _unitOfWork.CommitTransaction();
            //}

        }

        public async Task AddArticleTransactionWithAnotherTable(ArticleModel article)
        {
            //using (var context = new GoldhayAdminContext())
            //{
            await _unitOfWork.BeginTransaction();
            
            var resultCategory = await _unitOfWork.GetRepository<Categories>().
                Add(new Categories { CategoryName = "test" });

            await _unitOfWork.GetRepository<Articles>().Add(new Articles { Title = article.Name 
                ,CategoryId=resultCategory.CategoryId});
            //await _unitOfWork.art.Repo..Add(new Articles { Title = article.Name } );
            await _unitOfWork.SaveChangesAsync();
            _unitOfWork.CommitTransaction();
            //}

        }

        public IEnumerable<ArticleModel> Get()
        {
            using (var context = new GoldhayAdminContext())
            {
                var result = _unitOfWork.GetRepository<Articles>().Get();
                return result.Select(x => new ArticleModel { Name = x.Title }).ToList();
            }
        }
    }
}
