using Microsoft.Extensions.Caching.Memory;
using Parsis.Authentication.Core.Contract;
using Parsis.Authentication.Core.Setup;
using Parsis.Authentication.Core.Type;

namespace Parsis.Authentication.Implement.Provider
{
    public class CacheProvider<T> : ICacheProvider<T>
    {
        private readonly CacheItemConfig _cacheConfig;

        private readonly IMemoryCache _cache;

        public CacheProvider(IMemoryCache cache, CacheItemConfig cacheConfig)
        {
            _cache = cache;
            _cacheConfig = cacheConfig;
        }

        public T GetFromCache()
        {
            var cachedResponse = _cache.Get(_cacheConfig.Key);
            return (T)cachedResponse;
        }

        public void SetCache(T value)
        {
            if (_cacheConfig.CacheType == CacheType.PerSecond)
                _cache.Set(_cacheConfig.Key, value, DateTimeOffset.Now.AddSeconds(_cacheConfig.AbsoluteExpiration));
            else
                _cache.Set(_cacheConfig.Key, value, new MemoryCacheEntryOptions { Priority = CacheItemPriority.NeverRemove });

        }

        public void ClearCache()
        {
            _cache.Remove(_cacheConfig.Key);
        }
    }
}
