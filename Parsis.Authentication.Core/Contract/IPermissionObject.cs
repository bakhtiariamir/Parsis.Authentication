using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;

public interface IPermissionObject : IObject
{
    AccessLevel Level
    {
        get;
    }

    string Path
    {
        get;
    }

    IEnumerable<IFieldAccess> FieldAccesses { get; }
}
