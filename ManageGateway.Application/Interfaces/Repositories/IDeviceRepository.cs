using ManageGateway.Application.Interfaces.Repositories.Base;
using ManageGateway.Domain.Models;

namespace ManageGateway.Application.Interfaces.Repositories
{
    public interface IDeviceRepository : IBaseRepository<Device>
    {
        Task<IReadOnlyList<Device>> GetAllWithIncludeAsync();
    }
}
