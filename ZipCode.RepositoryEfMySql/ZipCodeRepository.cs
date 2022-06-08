using Microsoft.EntityFrameworkCore;
using ZipCode.Core.Entities;
using ZipCode.Core.Interfaces.IRepositories;
using ZipCode.RepositoryEfMySql.Contexts;

namespace ZipCode.RepositoryEfMySql
{
    public class ZipCodeRepository : IZipCodeRepository
    {
        private readonly AppDbContext _context;

        public ZipCodeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddSync(ZipCodeEntity entity)
        {
            _context.ZipCode.Add(entity);

            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<List<ZipCodeEntity>> GetAsync(string zipCode)
        {
            List<ZipCodeEntity> entities;

            entities = await _context.ZipCode
            .Where(item => item.ZipCode == zipCode)
            .ToListAsync();

            return entities;
        }

        public async Task<List<ZipCodeEntity>> GetZipCodesByMunicipalityAsync(string state, string municipality)
        {
            List<ZipCodeEntity> entities;

            entities = await _context.ZipCode.Where(item => item.Municipality == municipality && item.State == state)
            .ToListAsync();

            return entities;
        }

        public async Task<List<string>> GetMunicipalitiesByStateAsync(string state)
        {
            List<string> list;

            list = await _context.ZipCode.Where(item=> item.City == state)
            .Select(x=> x.Municipality).Distinct().ToListAsync();

            return list;
        }

        public async Task<List<string>> GetStatesSync()
        {
            try
            {
                List<string> list;

                list = await _context.ZipCode.Select(x=> x.City).Distinct().ToListAsync();                

                return list;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}