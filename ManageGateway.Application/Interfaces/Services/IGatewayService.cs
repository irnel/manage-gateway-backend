using ManageGateway.Domain.Models;

namespace ManageGateway.Application.Interfaces.Services
{
    public interface IGatewayService
    {
        Task<IReadOnlyList<Gateway>> GetAllAsync();
        Task<IReadOnlyList<Gateway>> GetAllWithIncludeAsync();
        Task<Gateway> GetByIdAsync(string serialNumber);
        Task<Gateway> GetByIdWithIncludeAsync(string serial);
    }
}
