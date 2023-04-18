using Microsoft.EntityFrameworkCore;
using NewsPortal.DAL.NewsPortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.DAL
{
    public class NewsPortalDbContext : DbContext
    {
        public NewsPortalDbContext(DbContextOptions<NewsPortalDbContext> options)
          : base(options)
        {

        }
        public DbSet<News> News { get; set; }
        public DbSet<User> User { get; set; }
    }
}
