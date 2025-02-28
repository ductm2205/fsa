using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    T? GetById(Guid id);

    Task<IEnumerable<T>> GetAllAsync();

    IEnumerable<T> GetAll();

    void Update(T entity);

    void Delete(T entity);

    Task SaveChangesAsync();
}