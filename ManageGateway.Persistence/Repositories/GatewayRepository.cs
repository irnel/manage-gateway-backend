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
    public class GatewayRepository : BaseRepository<Gateway>, IGatewayRepository
    {
        public GatewayRepository(
            ApplicationDbContext context, Func<CacheTech, ICacheService> cacheService)
            : base(context, cacheService)
        {
        }

        public async Task<IReadOnlyList<Gateway>> GetAllWithIncludeAsync()
        {
            //string gatewayCacheKey = "GatewayCacheKey";

            //if (!CacheService(GetCacheTech).TryGet(gatewayCacheKey, out IReadOnlyList<Gateway> cachedList))
            //{
            //    cachedList = await Context.Gateways
            //        .Include(g => g.Devices)
            //        .ToListAsync();

            //    CacheService(GetCacheTech).Set(gatewayCacheKey, cachedList);
            //    BackgroundJob.Enqueue(() => RefreshCache(gatewayCacheKey));
            //}

            //return cachedList;
            
            return await Context.Gateways.Include(g => g.Devices).ToListAsync();
        }

        public async Task<Gateway> GetByIdWithIncludeAsync(string serial)
        {
            return await Context.Gateways
                .Include(g => g.Devices)
                .FirstOrDefaultAsync(g => g.SerialNumber == serial);
        }
    }
}
