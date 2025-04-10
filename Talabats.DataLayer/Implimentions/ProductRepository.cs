using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabats.DataLayer.Repositories;
using Talabats.RepositoryLayer.Data;
using Talabats.RepositoryLayer.Entities;

namespace Talabats.DataLayer.Implimentions
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _applicationContext;
        public ProductRepository(ApplicationContext applicationContext)
        {
            applicationContext = _applicationContext;
        }
        public async Task AddProduct(Product items)
        {
            await _applicationContext.products.AddAsync(items);
            await _applicationContext.SaveChangesAsync();
        }
        public Task<Product> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<Product> updateProduct(Product items)
        {
            throw new NotImplementedException();
        }
    }
}
