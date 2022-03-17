using ManageGateway.Domain.Models;

namespace ManageGateway.Application.Interfaces.Services
{
    public interface IDeviceService
    {
        Task<IReadOnlyList<Device>> GetAllAsync();
        Task<IReadOnlyList<Device>> GetAllWithIncludeAsync();
        Task<Device> GetByIdAsync(string uid);
        Task AddAsync(Device device);
        Task DeleteAsync(Device device);
    }
}
