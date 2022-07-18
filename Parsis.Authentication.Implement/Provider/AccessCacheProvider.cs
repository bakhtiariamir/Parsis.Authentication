using Microsoft.Extensions.Caching.Memory;
using Parsis.Authentication.Core.Contract;
using Parsis.Authentication.Core.Setup;
using Parsis.Authentication.Core.Type;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Provider;
public class AccessCacheProvider : CacheProvider<IDictionary<string, IAccess>>, IAccessCacheProvider
{
    public AccessCacheProvider(IMemoryCache  memoryCache, CacheConfig cacheConfig) : base(memoryCache, cacheConfig.CacheItemsConfig.FirstOrDefault(item => item.CachedObjectType == CachedObjectType.Access))
    {

    }
}
