using System.Linq.Expressions;

namespace CompanyManagement.Infrastructure.Persistence.Repositories;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> GetPagedResultAsync(int pageNumber, int pageSize);
    Task<int> CountAsync();
    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    Task AddRangeAsync(IEnumerable<T> entities);
    Task UpdateRangeAsync(IEnumerable<T> entities);
    Task DeleteRangeAsync(IEnumerable<T> entities);
}