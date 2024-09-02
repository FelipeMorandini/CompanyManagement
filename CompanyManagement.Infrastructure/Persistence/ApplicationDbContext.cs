using CompanyManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Task = CompanyManagement.Domain.Entities.Task;

namespace CompanyManagement.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public DbSet<AuditLog> AuditLogs { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<Permission> Permissions { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<Task> Tasks { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<UserPermission> UserPermissions { get; set; } = null!;
    public DbSet<UserProject> UserProjects { get; set; } = null!;
    public DbSet<UserRole> UserRoles { get; set; } = null!;

    public new DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly); 
    }
}