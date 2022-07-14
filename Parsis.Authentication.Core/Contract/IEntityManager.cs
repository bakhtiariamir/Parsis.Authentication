namespace Parsis.Authorization.Core.Contract;
public interface IEntityManager<TEntity, TObject, in TType> : IObjectManager<TEntity> where TEntity : IEntity<TType> where TObject : IObject
{
    Task<TEntity> Find(string predicate);

    Task<TEntity> Find(TType id);

    Task Save(TEntity entity);

    Task Delete(TEntity entity);

    Task Delete(TType id);

    Task<IEnumerable<TEntity>> GetAll();

    IAsyncEnumerable<TEntity> GetAll(string predicate);

    Task<bool> IsMatch(string predicate);
    Task<TObject> Parse(string predicate);
}
