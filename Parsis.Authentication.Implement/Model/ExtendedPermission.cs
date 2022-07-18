using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Implement.Model;
public class ExtendedPermission : BaseExtendedObject, IExtendedPermission
{
    public string Predicate { get; set; }
    public AccessLevel Level { get; set; }
    public string Path { get; set; }
    public IEnumerable<IFieldAccess> FieldAccesses { get; set; }

}
