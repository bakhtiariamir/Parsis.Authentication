namespace Parsis.Authorization.Core.Contract;

public interface IUserPermission : IObject
{
    string UserName
    {
        get;
        set;
    }

    string Permission
    {
        get;
        set;
    }

    IExtendedPermission PermissionObject
    {
        get;
        set;
    }
}
