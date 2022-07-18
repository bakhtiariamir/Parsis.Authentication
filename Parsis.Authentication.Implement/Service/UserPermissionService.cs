using Parsis.Authentication.Core.Contract;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Manager;
public class UserPermissionService : IUserPermissionService, IEnsureLoadedService
{
    private readonly IUserPermissionCacheProvider _userPermissionCacheProvider;

    public UserPermissionService(IUserPermissionCacheProvider userPermissionCacheProvider)
    {
        _userPermissionCacheProvider = userPermissionCacheProvider;
    }

    public Task<IUserPermission> Create(string predicate)
    {
        throw new NotImplementedException();
    }

    public Task EnsureLoaded()
    {
        throw new NotImplementedException();
    }

    public Task<IUserPermission> Get(string predicate)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IUserPermission> GetAll()
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<IUserPermission> GetAll(string predicate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsMatch(string predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<IExtendedPermission>> Parse(string predicate)
    {
        throw new NotImplementedException();
    }
}

