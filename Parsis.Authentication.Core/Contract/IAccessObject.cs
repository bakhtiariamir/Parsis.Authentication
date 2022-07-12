using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;

public interface IAccessObject : IObject
{
    AccessLevel Level
    {
        get;
        set;
    }

    string Path
    {
        get;
        set;
    }

    IEnumerable<IFieldAccess> FieldAccesses
    {
        get;
        init;
    }
}
