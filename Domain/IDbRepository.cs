using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDbRepository<T>
     where T : class, IDbEntity
    {
        IQueryable<T> AllItems { get; }       
        Task<List<T>> ToListAsync();
        Task<int> AddItemAsync(T item);
        Task<int> AddItemsAsync(IEnumerable<T> items);
        Task<T> GetItemAsync(Guid id);
        Task<bool> ChangeItemAsync(T item);
        Task<bool> DeleteItemAsync(Guid id);
        Task<int> SaveChangesAsync();
    }
}
