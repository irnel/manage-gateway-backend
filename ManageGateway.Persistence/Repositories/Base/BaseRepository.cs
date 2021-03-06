using Hangfire;
using ManageGateway.Application.Interfaces.Repositories.Base;
using ManageGateway.Application.Interfaces.Services;
using ManageGateway.Domain.Enums;
using ManageGateway.Persistence.AppContext;
using Microsoft.EntityFrameworkCore;

namespace ManageGateway.Persistence.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public readonly ApplicationDbContext _context;
        // Cache Attributes and Properties
        private readonly static CacheTech cacheTech = CacheTech.Memory;
        private readonly string cacheKey = $"{typeof(T)}";
        private readonly Func<CacheTech, ICacheService> _cacheService;

        public ApplicationDbContext Context => _context;
        public CacheTech GetCacheTech => cacheTech;
        public string CacheKey => cacheKey;
        public Func<CacheTech, ICacheService> CacheService => _cacheService;

        public BaseRepository(ApplicationDbContext context, Func<CacheTech, ICacheService> cacheService)
        {
            _context = context;
            _cacheService = cacheService;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            //BackgroundJob.Enqueue(() => RefreshCache(cacheKey));
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            //BackgroundJob.Enqueue(() => RefreshCache(cacheKey));
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            //if (!_cacheService(cacheTech).TryGet(cacheKey, out IReadOnlyList<T> cachedList))
            //{
            //    cachedList = await _context.Set<T>().ToListAsync();
            //    CacheService(GetCacheTech).Set(cacheKey, cachedList);

            //    BackgroundJob.Enqueue(() => RefreshCache(cacheKey));
            //}

            //return cachedList;
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RefreshCache(string key)
        {
            _cacheService(cacheTech).Remove(key);
            var cachedList = await _context.Set<T>().ToListAsync();
            _cacheService(cacheTech).Set(key, cachedList);
        }
    }
}
