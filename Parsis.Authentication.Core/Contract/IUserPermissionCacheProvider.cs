using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Core.Contract;
public interface IUserPermissionCacheProvider : ICacheProvider<IUserPermission>
{
}
