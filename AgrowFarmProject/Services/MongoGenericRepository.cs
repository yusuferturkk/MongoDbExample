using AgrowFarmProject.Models;
using AgrowFarmProject.Settings;
using MongoDB.Driver;

namespace AgrowFarmProject.Services
{
    public class MongoGenericRepository<TEntity> : IMongoGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IMongoCollection<TEntity> _collection;

        public MongoGenericRepository(IDatabaseSettings databaseSettings)
        {
            var database = new MongoClient(databaseSettings.ConnectionString).GetDatabase(databaseSettings.DatabaseName);
            _collection = database.GetCollection<TEntity>(GetCollectionName(typeof(TEntity)));
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?.CollectionName;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var values = await _collection.Find(entity => true).ToListAsync();
            return values;
        }

        public async Task<TEntity> GetAsync()
        {
            var values = await _collection.Find(entity => true).FirstOrDefaultAsync();
            return values;
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            var values = await _collection.Find<TEntity>(x => x.Id == id).FirstOrDefaultAsync();
            return values;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _collection.FindOneAndReplaceAsync(x => x.Id == entity.Id, entity);
        }
    }
}
