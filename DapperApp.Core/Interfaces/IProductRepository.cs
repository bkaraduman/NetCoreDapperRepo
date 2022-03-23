using Dapper.Application.Entities;

namespace DapperApp.Core.Interfaces
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetAllByCategoryId(int categoryId);
    }
}
