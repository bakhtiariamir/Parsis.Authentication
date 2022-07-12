using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Model;
public class UserPermission<TType> : BaseEntity<TType>, IUserPermission<TType>
{
    public string UserName { get; set; }
    public string Permission { get; set; }
    public IPermissionObject PermissionObject { get; init; }

    public UserPermission(TType id, string userName, string permission) : base(id)
    {
        UserName = userName;
        Permission = permission;
    }

}

