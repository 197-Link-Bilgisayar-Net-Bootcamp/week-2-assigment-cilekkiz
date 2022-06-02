using Week2WebAPI.Core.Models;
using Week2WebAPI.Core.Shared.Interfaces;

namespace Week2WebAPI.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAsyncRepository<Product> ProductRepository { get; }

        Task<int> SaveAsync();

    }
}
