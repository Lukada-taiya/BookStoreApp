using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Models.Common;

namespace Bookstore.Application
{
    public interface IGenericRepository<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> GetAsync(FormattableString query);

        Task<IEnumerable<TEntity>> GetAllAsync(FormattableString query);

        Task<int> DeleteAsync(FormattableString query);

        Task<int> UpdateAsync(FormattableString query);

        Task<int> Add(FormattableString query);

        Task<int> GetId(FormattableString query);
    }
}
