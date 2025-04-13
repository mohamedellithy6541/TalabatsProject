using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabats.DataLayer.Entities;
using Talabats.DataLayer.Repositories;
using Talabats.RepositoryLayer.Data;

namespace Talabats.RepositoryLayer.Implimentions
{
    public class GenaricRepository<T> : IGenaricrepository<T> where T : BaseEntities
    {
        private readonly ApplicationContext _context;

        public GenaricRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Task AddProduct(T items)
        {
            throw new NotImplementedException();
        }
        public Task<T> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().Where(i=>i.Id==id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
          var Data = await _context.Set<T>().ToListAsync();
            return Data;

        }

        public Task<T> updateProduct(T items)
        {
            throw new NotImplementedException();
        }
    }
}
