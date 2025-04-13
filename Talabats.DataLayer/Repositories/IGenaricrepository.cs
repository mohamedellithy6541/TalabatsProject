using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabats.DataLayer.Entities;

namespace Talabats.DataLayer.Repositories
{
    public interface IGenaricrepository<T> where T : BaseEntities
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task AddProduct(T items);
        Task<T> updateProduct(T items);
        Task<T> DeleteProduct(int id);
    }
}
