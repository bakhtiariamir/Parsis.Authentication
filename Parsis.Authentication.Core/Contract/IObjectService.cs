namespace Parsis.Authorization.Core.Contract;
public interface IObjectService<TObject, TExtendedObject>
{
    Task<TObject> Create(string predicate);

    Task<TObject> Get(string predicate);

    IAsyncEnumerable<TObject> GetAll();

    IAsyncEnumerable<TObject> GetAll(string predicate);

    Task<bool> IsMatch(string predicate);

    Task<IEnumerable<TExtendedObject>> Parse(string predicate);
}
