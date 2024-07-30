using Microsoft.EntityFrameworkCore;


namespace ExerciseTracker.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    #region Fields

    private readonly DbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    #endregion
    #region Constructors
    
    public Repository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    #endregion

    public async Task<int> AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
        return await _dbContext.SaveChangesAsync();
    }

    public IQueryable<TEntity> Get()
    {
        return _dbContext.Set<TEntity>();
    }

    public async Task<TEntity?> GetAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<int> UpdateAsync(TEntity entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return await _dbContext.SaveChangesAsync();
    }
}
