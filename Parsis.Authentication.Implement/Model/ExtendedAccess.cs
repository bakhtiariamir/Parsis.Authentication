using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Implement.Model;
public class ExtendedAccess : BaseExtendedObject, IExtendedAccess
{
    public AccessLevel Level { get; set; }
    public string Path { get; set; }
    public IEnumerable<IFieldAccess> FieldAccesses { get; init; }
}
