using CoreAppArchitectureJWT.Data.Repositories.Interfaces;

namespace CoreAppArchitectureJWT.Data.Repositories.Implementations
{
    /*
      1. Below section can be uncommented and modified as per your requirement.
      2. Below code is given for entity framework core.
      3. You can add your DB Context and modify this class.
     */


    //public class GenericRepository<T> : IGenericRepository<T> where T : class
    //{
    //    //protected readonly AppDbContext _context;
    //    protected readonly DbSet<T> _dbSet;

    //    public GenericRepository(AppDbContext context)
    //    {
    //        _context = context;
    //        _dbSet = _context.Set<T>();
    //    }

    //    public virtual async Task<IEnumerable<T>> GetAllAsync()
    //    {
    //        return await _dbSet.ToListAsync();
    //    }

    //    public virtual async Task<T?> GetByIdAsync(Guid id)
    //    {
    //        return await _dbSet.FindAsync(id);
    //    }

    //    public virtual async Task AddAsync(T entity)
    //    {
    //        await _dbSet.AddAsync(entity);
    //    }

    //    public virtual void Update(T entity)
    //    {
    //        _dbSet.Update(entity);
    //    }

    //    public virtual void Delete(T entity)
    //    {
    //        _dbSet.Remove(entity);
    //    }

    //    public async Task SaveChangesAsync()
    //    {
    //        await _context.SaveChangesAsync();
    //    }
    //}
}
