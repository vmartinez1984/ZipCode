using AutoMapper;
using ZipCode.Core.Dtos;
using ZipCode.Core.Entities;
using ZipCode.Core.Interfaces.IBusinessLayer;
using ZipCode.Core.Interfaces.IRepositories;

namespace ZipCode.BusinessLayer.Bl
{
    public class ZipCodeBl: IZipCodeBl
    {
        private IUnitOfWorkRepository _repository;
        private IMapper _mapper;

        public ZipCodeBl(IMapper mapper, IUnitOfWorkRepository repository)
        {
            _repository = repository;  
            _mapper = mapper;   
        }

        public async Task<List<ZipCodeDto>> GetZipCodes(string zipCode)
        {
            List<ZipCodeEntity> entities;
            List<ZipCodeDto> list;

            entities = await _repository.ZipCode.GetAsync(zipCode);
            list = _mapper.Map<List<ZipCodeDto>>(entities);

            return list;
        }

        public async Task<List<ZipCodeDto>> GetZipCodesByMunicipalityAsync(string state, string municipality)
        {
            List<ZipCodeEntity> entities;
            List<ZipCodeDto> list;

            entities = await _repository.ZipCode.GetZipCodesByMunicipalityAsync(state, municipality);
            list = _mapper.Map<List<ZipCodeDto>>(entities);

            return list;
        }

        public async Task<List<string>> GetMunicipalitiesByStateAsync(string state)
        {
            List<string> list;

            list = await _repository.ZipCode.GetMunicipalitiesByStateAsync(state);

            return list;
        }

        public async Task<List<string>> GetStatesSync()
        {
            List<string> list;

            list = await _repository.ZipCode.GetStatesSync();

            return list;
        }
    }//end class
}