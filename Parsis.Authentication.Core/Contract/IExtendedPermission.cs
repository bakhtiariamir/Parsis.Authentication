using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;

public interface IExtendedPermission : IExtendedObject
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
