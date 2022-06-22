using ZipCode.Core.Entities;

namespace ZipCode.Core.Interfaces.IRepositories
{
    public interface IZipCodeRepository
    {
        Task<int> AddSync(ZipCodeEntity entity);

        Task<List<ZipCodeEntity>> GetAsync(string zipCode);

        Task<List<ZipCodeEntity>> GetZipCodesByMunicipalityAsync(string state, string municipality1);

        Task<List<string>> GetMunicipalitiesByStateAsync(string state);
        Task<List<string>> GetStatesSync();
    }
}