using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using todoapp.mvc.Models;

namespace todoapp.mvc.Data;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<Models.Task> Tasks { get; set; }

    public DbSet<Category> Categories { get; set; }

    // add
    public override int SaveChanges()
    {
        BeforeSaveChanges();
        return base.SaveChanges();
    }

    // update
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        BeforeSaveChanges();
        return base.SaveChangesAsync(cancellationToken);
    }

    // before modifications
    private void BeforeSaveChanges()
    {
        var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

        foreach (var entity in entities)
        {
            if (entity.State == EntityState.Added && entity.Entity is BaseEntity entity1)
            {
                entity1.CreatedAt = DateTime.Now;
            }
            else if (entity.State == EntityState.Modified && entity.Entity is BaseEntity entity2)
            {
                entity2.UpdatedAt = DateTime.Now;
            }
        }
    }

}
