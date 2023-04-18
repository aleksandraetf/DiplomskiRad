using NewsPortal.Repository.NewsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Repository.UnitOfWork
{
    public interface INewsUnitOfWork : IDisposable
    {
        INewsRepository News { get; }
        int Complete();

    }
}
