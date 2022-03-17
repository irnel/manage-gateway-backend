using ManageGateway.Application.Interfaces.Repositories;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Models;

namespace ManageGateway.Infrastructure.Services
{
    public class GatewayService : IGatewayService
    {
        private readonly IGatewayRepository _repo;

        public GatewayService(IGatewayRepository repo) => _repo = repo;

        public async Task<IReadOnlyList<Gateway>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public Task<IReadOnlyList<Gateway>> GetAllWithIncludeAsync()
        {
            return _repo.GetAllWithIncludeAsync();
        }

        public async Task<Gateway> GetByIdAsync(string serialNumber)
        {
            return await _repo.GetByIdAsync(serialNumber);
        }

        public async Task<Gateway> GetByIdWithIncludeAsync(string serial)
        {
            return await _repo.GetByIdWithIncludeAsync(serial);
        }
    }
}
