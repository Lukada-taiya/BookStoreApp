using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(FormattableString query);

        Task<IEnumerable<TEntity>> GetAllAsync(FormattableString query);

        Task<int> DeleteAsync(FormattableString query);

        Task<int> UpdateAsync(FormattableString query);

        Task<int> Add(FormattableString query);
    }
}
