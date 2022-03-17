using AutoMapper;
using FluentValidation;
using ManageGateway.Application.DTOs;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManageGateway.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _service;
        private readonly IMapper _mapper;
        
        public DeviceController(IDeviceService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet(), Route("GetAll")]
        public async Task<ActionResult<IEnumerable<DeviceDTO>>> GetAllAsync()
        {
            var devices = await _service.GetAllAsync();
            var mappedDevices = _mapper.Map<List<DeviceDTO>>(devices);

            return Ok(mappedDevices);
        }

        [HttpGet("{uid}")]
        public async Task<ActionResult<DeviceDTO>> GetByIdAsync(string uid)
        {
            var device = await _service.GetByIdAsync(uid);

            if (device == null)
                return NotFound();

            var mappedDevice = _mapper.Map<DeviceDTO>(device);

            return Ok(mappedDevice);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] DeviceDTO device)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var mappedDevice = _mapper.Map<Device>(device);
            await _service.AddAsync(mappedDevice);

            return NoContent();
        }

        [HttpDelete("{uid}")]
        public async Task<IActionResult> DeleteAsync(string uid)
        {
            var device = await _service.GetByIdAsync(uid);

            if (device == null)
                return NotFound();

            await _service.DeleteAsync(device);

            return NoContent();
        }
    }
}
