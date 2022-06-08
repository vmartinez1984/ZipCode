using ZipCode.Core.Dtos;

namespace ZipCode.Core.Interfaces.IBusinessLayer
{
    public interface IZipCodeBl
    {
        Task<List<ZipCodeDto>> GetZipCodes(string zipCode);

        Task<List<ZipCodeDto>> GetZipCodesByMunicipalityAsync(string state, string alcaldia);

        Task<List<string>> GetMunicipalitiesByStateAsync(string state);

        Task<List<string>> GetStatesSync();
    }
}