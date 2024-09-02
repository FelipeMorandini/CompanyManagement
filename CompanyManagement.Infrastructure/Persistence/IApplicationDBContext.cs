using CompanyManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = CompanyManagement.Domain.Entities.Task;

namespace CompanyManagement.Infrastructure.Persistence;

public interface IApplicationDbContext
{
    DbSet<AuditLog> AuditLogs { get; set; }
    DbSet<Comment> Comments { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<Permission> Permissions { get; set; }
    DbSet<Project> Projects { get; set; }
    DbSet<Role> Roles { get; set; }
    DbSet<Task> Tasks { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserPermission> UserPermissions { get; set; }
    DbSet<UserProject> UserProjects { get; set; }
    DbSet<UserRole> UserRoles { get; set; }
    DbSet<TEntity> Set<TEntity>() where TEntity : class; 
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}