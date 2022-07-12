using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authentication.Implement.Model;
public class AccessObject : BaseObject, IAccessObject
{
    public AccessLevel Level { get; set; }
    public string Path { get; set; }
    public IEnumerable<IFieldAccess> FieldAccesses { get; init; }
}
