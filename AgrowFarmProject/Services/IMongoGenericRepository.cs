using AgrowFarmProject.Models;

namespace AgrowFarmProject.Services
{
    public interface IMongoGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync();
        Task<TEntity> GetByIdAsync(string id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);
    }
}
