using AutoMapper;
using ManageGateway.Application.DTOs;
using ManageGateway.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManageGateway.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        private readonly IGatewayService _service;
        private readonly IMapper _mapper;

        public GatewayController(IGatewayService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet, Route("GetAll")]
        public async Task<ActionResult<IEnumerable<GatewayDTO>>> GetAllAsync()
        {
            var gateways = await _service.GetAllAsync();
            var mappedGateways = _mapper.Map<List<GatewayDTO>>(gateways);

            return Ok(mappedGateways);
        }

        [HttpGet, Route("GetAllWithInclude")]
        public async Task<ActionResult<IEnumerable<GatewayWithDevices>>> GetAllWithIncludeAsync()
        {
            var gateways = await _service.GetAllWithIncludeAsync();
            var mappedGateways = _mapper.Map<List<GatewayWithDevices>>(gateways);

            return Ok(mappedGateways);
        }

        [HttpGet(), Route("GetById/{serial}")]
        public async Task<ActionResult<GatewayDTO>> GetByIdAsync(string serial)
        {
            if (string.IsNullOrEmpty(serial))
                return BadRequest("Value cannot be null or empty. (Parameter 'serial' is required)");

            var gateway = await _service.GetByIdAsync(serial);

            if (gateway == null)
                return NotFound();            

            return Ok(_mapper.Map<GatewayDTO>(gateway));
        }

        [HttpGet(), Route("GetByIdWithInclude/{serial}")]
        public async Task<ActionResult<GatewayDTO>> GetByIdWithIncludeAsync(string serial)
        {
            if (string.IsNullOrEmpty(serial))
                return BadRequest("Value cannot be null or empty. (Parameter 'serial' is required)");

            var gateway = await _service.GetByIdWithIncludeAsync(serial);

            if (gateway == null)
                return NotFound();

            return Ok(_mapper.Map<GatewayWithDevices>(gateway));
        }
    }
}
