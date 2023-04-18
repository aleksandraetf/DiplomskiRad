using NewsPortal.Repository.UsersRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.UnitOfWork
{
    public interface IUserUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        int Complete();
    }
}
