namespace Parsis.Authorization.Core.Contract;

public interface IUserPermission<TType> : IEntity<TType>
{
    string UserName
    {
        get;
    }    

    string Permission
    {
        get;
    }

    IPermissionObject PermissionObject 
    {
        get;
        init;
    }
}
