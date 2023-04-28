using System;
using Alpha.API.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Alpha.API.Data.Repository
{
    public class AlphaRepository<T> : IAlphaRepository<T> where T : class
    {
        private readonly AlphaBaseContext _context;
        protected readonly DbSet<T> _dbSet;

        public AlphaRepository(AlphaBaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}

