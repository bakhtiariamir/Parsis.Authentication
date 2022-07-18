using Parsis.Authentication.Core.Type;

namespace Parsis.Authentication.Core.Setup;
public class CacheConfig
{
    public IEnumerable<CacheItemConfig> CacheItemsConfig { get; set; }
}

public class CacheItemConfig
{
    public string Key { get; set; }

    public CachedObjectType CachedObjectType { get; set; }
    public int AbsoluteExpiration { get; set; } = 1000;

    public CacheType CacheType { get; set; }
}