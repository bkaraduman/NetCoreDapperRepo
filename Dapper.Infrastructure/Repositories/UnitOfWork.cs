using DapperApp.Core.Interfaces;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository Products { get; }
        public UnitOfWork(IProductRepository productRepository)
        {
            Products = productRepository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // do stuff
            }
        }
    }
}
