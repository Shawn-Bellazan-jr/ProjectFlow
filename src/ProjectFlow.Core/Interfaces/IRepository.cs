using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFlow.Core.Interfaces
{
    public interface IRepository<T> where T : Project
    {
        Task<IEnumerable<T>> Get();
        Task<T?> Get(string id);
        Task<T?> CreateAsync(T entity);
        Task<T?> UpdateAsync(T entity);
        Task<T?> DeleteAsync(T entity);
        Task<IEnumerable<T>> DeleteAllAsync();

    }
}
