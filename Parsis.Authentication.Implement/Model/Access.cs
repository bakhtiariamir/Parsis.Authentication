using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Model;

public class Access : BaseObject, IAccess
{
    public string Title
    {
        get;
        set;
    }

    public string Predicate
    {
        get;
        set;
    }

    public IEnumerable<IExtendedAccess> AccessObject
    {
        get;
        set;
    }
}
