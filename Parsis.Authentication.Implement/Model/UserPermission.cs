using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Model;
public class UserPermission : BaseObject, IUserPermission
{
    public string UserName { get; set; }
    public string Permission { get; set; }
    public IExtendedPermission PermissionObject { get; set; }

}

