using Library.data;
using Library.Reposatiry.Interface;
using Microsoft.EntityFrameworkCore;

namespace Library.Reposatiry.MemberShip
{
    public class Genaric<T> : IGenrac<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Genaric(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }
          //mohamed ahmed mohamed ahmed mohamed ahmed mohame..[d
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync() //////////////////////////////////why _context not _dbset
        {
             await _context.SaveChangesAsync();jgljqs
        }//ljpo

        public async Task UpdateAsync(T entity)
        {
             _dbSet.Update(entity);
        }
    }
}
