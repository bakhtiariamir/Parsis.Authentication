using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Core.Contract;
public interface IAccessCacheProvider : ICacheProvider<IDictionary<string, IAccess>>
{
}
