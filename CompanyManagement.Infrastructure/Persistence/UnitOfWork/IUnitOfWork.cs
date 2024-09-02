using CompanyManagement.Domain.Entities;
using CompanyManagement.Infrastructure.Persistence.Repositories;

namespace CompanyManagement.Infrastructure.Persistence.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IRepository<T> Repository<T>() where T : class, IEntity;
    Task<int> SaveChangesAsync();
}