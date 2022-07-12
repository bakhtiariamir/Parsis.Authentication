using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Implement.Model;
public class PermissionObject : BaseObject, IPermissionObject
{
    public string Predicate { get; private set; }
    public AccessLevel Level { get; private set; }
    public string Path { get; private set; }
    public IEnumerable<IFieldAccess> FieldAccesses { get; private set; }

    public PermissionObject(string predicate, AccessLevel level, string path, IEnumerable<IFieldAccess> fieldAccesses)
    {
        Predicate = predicate;
        Level = level;
        Path = path;
        FieldAccesses = fieldAccesses;
    }
}
