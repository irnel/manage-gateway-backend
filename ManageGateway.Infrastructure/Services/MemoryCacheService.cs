using ManageGateway.Application.Configurations;
using ManageGateway.Application.Interfaces.Services;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace ManageGateway.Infrastructure.Services
{
    public class MemoryCacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly CacheConfiguration _cacheConfig;
        private readonly MemoryCacheEntryOptions _cacheOptions;

        public MemoryCacheService(IMemoryCache memoryCache, IOptions<CacheConfiguration> cacheConfig)
        {
            _memoryCache = memoryCache;
            _cacheConfig = cacheConfig.Value;

            if (_cacheConfig != null)
            {
                _cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(_cacheConfig.AbsoluteExpirationInHours),
                    SlidingExpiration = TimeSpan.FromMinutes(_cacheConfig.SlidingExpirationInMinutes),
                    Priority = CacheItemPriority.High
                };
            }
        }

        public void Remove(string cacheKey)
        {
            _memoryCache.Remove(cacheKey);
        }

        public T Set<T>(string cacheKey, T value)
        {
            return _memoryCache.Set(cacheKey, value, _cacheOptions);
        }

        public bool TryGet<T>(string cacheKey, out T value)
        {
            _memoryCache.TryGetValue(cacheKey, out value);

            return value != null;
        }
    }
}
