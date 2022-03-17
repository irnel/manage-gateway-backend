using ManageGateway.Application.Interfaces.Repositories;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Models;

namespace ManageGateway.Infrastructure.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _repo;

        public DeviceService(IDeviceRepository repo) => _repo = repo;

        public async Task AddAsync(Device device)
        {
            await _repo.AddAsync(device);
        }

        public async Task<IReadOnlyList<Device>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Device> GetByIdAsync(string uid)
        {
            return await _repo.GetByIdAsync(uid);
        }

        public async Task DeleteAsync(Device device)
        {
            await _repo.DeleteAsync(device);
        }

        public Task<IReadOnlyList<Device>> GetAllWithIncludeAsync()
        {
            return _repo.GetAllWithIncludeAsync();
        }
    }
}
