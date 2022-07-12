using Parsis.Authentication.Implement.Base;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Model;

public class Access<TType> : BaseEntity<TType>, IAccess<TType>
{
    public string Title
    {
        get;
    }

    public string Predicate
    {
        get;
    }

    public IEnumerable<IAccessObject> AccessObject
    {
        get;
        init;
    }
    public Access(TType id, string title, string predicate) : base(id)
    {
        Title = title;
        Predicate = predicate;
    }
}
