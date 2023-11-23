using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Application;
using Bookstore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Persistence
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DatabaseContext _dbContext;
        public GenericRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Add(FormattableString query)
        {
            var result = _dbContext.Database.ExecuteSqlInterpolated(query);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<int> DeleteAsync(FormattableString query)
        {
            var result = _dbContext.Database.ExecuteSqlInterpolated(query);

            await _dbContext.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(FormattableString query)
        {
            var result = await _dbContext.Set<TEntity>().FromSqlInterpolated(query).ToListAsync() ; 

            return result;
        }

        public async Task<TEntity> GetAsync(FormattableString query)
        {
            List<TEntity> result = await _dbContext.Set<TEntity>().FromSqlInterpolated(query).ToListAsync();

            return result.FirstOrDefault()!;
        }

        public async Task<int> UpdateAsync(FormattableString query)
        {
            var result = _dbContext.Database.ExecuteSqlInterpolated(query);
            await _dbContext.SaveChangesAsync();

            return result;
        }
    }
}
