using System;
using Microsoft.EntityFrameworkCore;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class GenericRepository<T>(ViVuStoreDbContext context) : IGenericRepository<T> where T : class
{
    private readonly ViVuStoreDbContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync<T>();
    }

    public T? GetById(Guid id)
    {
        return _dbSet.Find(id);
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public Task SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}
