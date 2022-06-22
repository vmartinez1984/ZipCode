using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using ZipCode.Core.DataSettings;
using ZipCode.Core.Entities;
using ZipCode.Core.Interfaces.IRepositories;

namespace ZipCode.RepositoryMongoDb
{
    public class ZipCodeRepository : IZipCodeRepository
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<ZipCodeModel> _collection;

        public ZipCodeRepository(IOptions<DataSettingMongoDb> dataSettings)
        {
            var mongoClient = new MongoClient(dataSettings.Value.ConnectionString);

            _mongoDatabase = mongoClient.GetDatabase(dataSettings.Value.DatabaseName);

            _collection = _mongoDatabase.GetCollection<ZipCodeModel>(dataSettings.Value.ZipCodeCollectionName);
        }

        public Task<int> AddSync(ZipCodeEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ZipCodeEntity>> GetAsync(string zipCode)
        {
            List<ZipCodeEntity> entities;

            var list = await _collection.Find(x => x.ZipCode == zipCode).ToListAsync();
            entities = list.Select(x => new ZipCodeEntity
            {
                Id = x.Id,
                ZipCode = x.ZipCode,
                City = x.City,
                Municipality = x.Municipality,
                Settement = x.Settement,
                SettementType = x.SettementType,
                State = x.State
            }).ToList();

            return entities;
        }

        public async Task<List<string>> GetMunicipalitiesByStateAsync(string state)
        {
            List<string?> list;

            // var filter = Builders<BsonDocument>.Filter
            var data = await _collection.Find(x => x.State == state).ToListAsync();
            list = data.OrderBy(x=>x.Municipality).Select(x => x.Municipality).Distinct().ToList();

            return list;
        }

        public async Task<List<string>> GetStatesSync()
        {
            var filter = new BsonDocument();
            var list = await _collection.DistinctAsync<string>("State", filter);

            return list.ToList();
        }

        public async Task<List<ZipCodeEntity>> GetZipCodesByMunicipalityAsync(string state, string municipality1)
        {
            List<ZipCodeEntity> entities;

            var list = await _collection.Find(x => x.State == state && x.Municipality == municipality1).ToListAsync();
            entities = list.Select(x => new ZipCodeEntity
            {
                Id = x.Id,
                ZipCode = x.ZipCode,
                City = x.City,
                Municipality = x.Municipality,
                Settement = x.Settement,
                SettementType = x.SettementType,
                State = x.State
            }).ToList();

            return entities;
        }
    }
}