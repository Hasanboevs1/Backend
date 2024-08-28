
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
   private readonly AppDbContext _db;
    private readonly DbSet<T> Users;

    public GenericRepository(AppDbContext db)
    {
        _db = db;
        Users = _db.Set<T>();
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var model = await Users.FindAsync(id);
        Users.Remove(model);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<T> InsertAsync(T entity)
    {
        var model = await Users.AddAsync(entity);
        await _db.SaveChangesAsync();
        return model.Entity;
    }

    public IQueryable<T> SelectAllAsync()
    {
        return Users;
    }

    public async Task<T> SelectByIdAsync(int id)
    {
        var model = await Users.FindAsync(id);

        return model;
    }

    public async Task<T> UpdateAsync(int id, T entity)
    {
        var existingEntity = await Users.FindAsync(id);

        if (existingEntity == null)
        {
            return null;
        }

        _db.Entry(existingEntity).CurrentValues.SetValues(entity);

        await _db.SaveChangesAsync();

        return existingEntity;
    }
}
