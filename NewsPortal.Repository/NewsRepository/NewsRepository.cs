using Microsoft.EntityFrameworkCore;
using NewsPortal.DAL;
using NewsPortal.DAL.NewsPortal;
using NewsPortal.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.NewsRepository
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        public NewsRepository(NewsPortalDbContext context) : base(context)
        {

        }

        public override IQueryable<News> GetAll(bool asNoTracking)
        {

            return DbContext.News.Include(news => news.User);
        }

        public IQueryable<News> GetAll(string search, int pageNumber, int pageSize)
        {
            return DbContext.News.Include(news => news.User)
                .Where(news => news.Text.ToLower().Contains(search.ToLower()))
                .Skip((pageNumber) * pageSize).Take(pageSize);
        }

        public IQueryable<News> GetByUser(string search, int pageNumber, int pageSize, int userId)
        {
            return DbContext.News.Include(news => news.User)
                .Where(news => news.Text.ToLower().Contains(search.ToLower()) && news.UserId == userId)
                .Skip((pageNumber) * pageSize).Take(pageSize);
        }
    }
}
