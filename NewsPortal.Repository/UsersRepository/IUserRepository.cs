using NewsPortal.DAL.NewsPortal;
using NewsPortal.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.UsersRepository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetUser(string username, string password);
    }
}
