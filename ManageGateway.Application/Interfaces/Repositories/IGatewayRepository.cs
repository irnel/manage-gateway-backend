using ManageGateway.Application.Interfaces.Repositories.Base;
using ManageGateway.Domain.Models;

namespace ManageGateway.Application.Interfaces.Repositories
{
    public interface IGatewayRepository : IBaseRepository<Gateway>
    {
        Task<IReadOnlyList<Gateway>> GetAllWithIncludeAsync();

        Task<Gateway> GetByIdWithIncludeAsync(string serial);
    }
}
