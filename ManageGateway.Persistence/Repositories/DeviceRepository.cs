using Hangfire;
using ManageGateway.Application.Interfaces.Repositories;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Enums;
using ManageGateway.Domain.Models;
using ManageGateway.Persistence.AppContext;
using ManageGateway.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace ManageGateway.Persistence.Repositories
{
    public class DeviceRepository : BaseRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(
            ApplicationDbContext context, Func<CacheTech, ICacheService> cacheService) 
            : base(context, cacheService)
        {
        }
    }
}
