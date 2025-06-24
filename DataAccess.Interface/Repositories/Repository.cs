using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TestTwoContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(TestTwoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id) ?? throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        async public Task Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await _dbSet.AddAsync(entity);            
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dbSet.Update(entity);            
        }

        public void Delete(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dbSet.Remove(entity);            

        }        
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
