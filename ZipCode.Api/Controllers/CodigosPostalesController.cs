using Microsoft.AspNetCore.Mvc;
using ZipCode.Core.Dtos;
using ZipCode.Core.Interfaces.IBusinessLayer;

namespace ZipCode.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CodigosPostalesController : ControllerBase
    {
        private readonly ILogger<CodigosPostalesController> _logger;
        private readonly IUnitOfWorkBl _unitOfWorkBl;

        public CodigosPostalesController(ILogger<CodigosPostalesController> logger, IUnitOfWorkBl unitOfWorkBl)
        {
            _logger = logger;
            _unitOfWorkBl = unitOfWorkBl;
        }

        [HttpGet("Estados", Name = "Estados")]
        public async Task<IActionResult> GetStates()
        {
            List<string> list;

            list = await _unitOfWorkBl.ZipCode.GetStatesSync();

            return Ok(list);
        }

        [HttpGet("Estados/{estado}/Alcaldias")]
        public async Task<IActionResult> GetMunicipalities(string estado)
        {
            List<string> list;

            list = await _unitOfWorkBl.ZipCode.GetMunicipalitiesByStateAsync(estado);

            return Ok(list);
        }

        [HttpGet("Estados/{estado}/Alcaldias/{alcaldia}")]
        public async Task<IActionResult> GetZipCodesByMunicipality(string estado, string alcaldia)
        {
            List<ZipCodeDto> list;

            list = await _unitOfWorkBl.ZipCode.GetZipCodesByMunicipalityAsync(estado, alcaldia);

            return Ok(list);
        }

        [HttpGet("{codigoPostal}")]
        public async Task<IActionResult> GetZipCodes(string codigoPostal)
        {
            List<ZipCodeDto> list;

            list = await _unitOfWorkBl.ZipCode.GetZipCodes(codigoPostal);

            return Ok(list);
        }
    }
}