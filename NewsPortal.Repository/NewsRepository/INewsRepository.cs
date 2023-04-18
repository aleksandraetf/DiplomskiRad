using NewsPortal.DAL.NewsPortal;
using NewsPortal.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.NewsRepository
{
    public interface INewsRepository : IBaseRepository<News>
    {
        IQueryable<News> GetAll(string search, int pageNumber, int pageSize);
        IQueryable<News> GetByUser(string search, int pageNumber, int pageSize, int userId);
    }
}
