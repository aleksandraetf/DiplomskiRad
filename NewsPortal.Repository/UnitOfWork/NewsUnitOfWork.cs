using NewsPortal.DAL;
using NewsPortal.Repository.NewsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.UnitOfWork
{
    public class NewsUnitOfWork : INewsUnitOfWork
    {

        private readonly NewsPortalDbContext _dbContext;
        public INewsRepository News { get; }

        public NewsUnitOfWork(NewsPortalDbContext context)
        {
            _dbContext = context;
            News = new NewsPortal.Repository.NewsRepository.NewsRepository(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
    }
}
