using Context;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IDbEntity
    {
        private AppDbContext _context;

        public DbRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> AllItems => _context.Set<T>();

        public async Task<int> AddItemAsync(T item)
        {
            try
            {
                await _context.Set<T>().AddAsync(item);
                return await SaveChangesAsync();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return 0;
            }
        }

        public async Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            try
            {
                await _context.Set<T>().AddRangeAsync(items);
                return await SaveChangesAsync();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return 0;
            }
        }

        public async Task<bool> ChangeItemAsync(T item)
        {
            try
            {
                T chageCandidate = _context.Set<T>()
                    .FirstOrDefault(n => n.Id==item.Id);
                
                if (chageCandidate != null)
                {
                    chageCandidate = item;
                    return await SaveChangesAsync()>0;
                }

                return false;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return false;
            }
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            try
            {
                T deleteCandidate = _context.Set<T>()
                    .FirstOrDefault(n => n.Id == id);

                if (deleteCandidate != null)
                {
                    _context.Set<T>().Remove(deleteCandidate);
                    return await SaveChangesAsync() > 0;
                }

                return false;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return false;
            }
        }

        public async Task<T> GetItemAsync(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<List<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
