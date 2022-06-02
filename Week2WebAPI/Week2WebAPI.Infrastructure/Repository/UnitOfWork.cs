using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2WebAPI.Core.Interfaces;
using Week2WebAPI.Core.Models;
using Week2WebAPI.Core.Shared.Interfaces;
using Week2WebAPI.Infrastructure.Database;

namespace Week2WebAPI.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WebAPIContext _dbContext;

        public UnitOfWork(WebAPIContext dbContext,
            IAsyncRepository<Product> sysProductRepository)
        {
            _dbContext = dbContext;

            ProductRepository = sysProductRepository;
        }

        public IAsyncRepository<Product> ProductRepository { get; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

    }
}
