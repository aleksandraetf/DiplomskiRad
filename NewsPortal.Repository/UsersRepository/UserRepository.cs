using NewsPortal.DAL;
using NewsPortal.DAL.NewsPortal;
using NewsPortal.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.UsersRepository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NewsPortalDbContext context) : base(context)
        {

        }

        public User GetUser(string username, string password)
        {
            return DbContext.User.FirstOrDefault(user => user.Username == username && user.Password == password);
        }
    }
}
