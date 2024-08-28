namespace API.Repositories;

public interface IGenericRepository<T> where T : class
{
    public Task<T> InsertAsync(T entity);
    public Task<T> UpdateAsync(int id, T entity);
    public Task<bool> DeleteAsync(int id);
    public Task<T> SelectByIdAsync(int id);
    public IQueryable<T> SelectAllAsync();
}