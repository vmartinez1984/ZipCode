using AutoMapper;
using ZipCode.Core.Dtos;
using ZipCode.Core.Entities;

namespace ZipCode.Core.Mappers
{
    public class ZipCodeMapper: Profile
    {
        public ZipCodeMapper()
        {
            CreateMap<ZipCodeEntity, ZipCodeDto>().ReverseMap();
        }
    }
}