using Dapper.Application.Entities;
using DapperApp.Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Dapper.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private const string _tableName = "Products";

        public ProductRepository(IConfiguration configuration) : base(_tableName, configuration)
        {
        }

        public async Task<List<Product>> GetAllByCategoryId(int categoryId)
        {
            var param = new
            {
                categoryId,
            };

            using (var connection = CreateConnection())
            {
                var result = connection.QueryAsync<Product>($"SELECT * FROM {_tableName} where CategoryID=@categoryId", commandType: System.Data.CommandType.Text, param: param).Result;

                return result.ToList();
            }
        }
    }
}
