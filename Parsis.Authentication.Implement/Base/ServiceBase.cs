using Parsis.Authentication.Core.Contract;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Base;
public abstract class ServiceBase<TObject, TExtendedObject> : IObjectService<TObject, TExtendedObject>
    where TObject : IObject, new()
{
    public async Task<TObject> Create(string predicate)
    {
        if (string.IsNullOrEmpty(predicate))
            return await Get(predicate);
        return new TObject();
    }

    public abstract Task<TObject> Get(string predicate);

    public abstract IAsyncEnumerable<TObject> GetAll();

    public abstract IAsyncEnumerable<TObject> GetAll(string predicate);

    public abstract Task<bool> IsMatch(string predicate);

    public abstract Task<IEnumerable<TExtendedObject>> Parse(string predicate);
}
