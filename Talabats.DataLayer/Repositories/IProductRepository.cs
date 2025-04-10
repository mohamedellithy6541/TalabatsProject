using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabats.RepositoryLayer.Entities;

namespace Talabats.DataLayer.Repositories
{
    public interface IProductRepository
    {
       Task<IEnumerable<Product>> GetAll();
       Task<Product> Get(int id);
       Task AddProduct(Product items);
       Task<Product> updateProduct(Product items);
       Task<Product> DeleteProduct(int id);
       
    }
}
