namespace Parsis.Authorization.Core.Contract;
public interface IObjectManager<TObject> where TObject : IObject
{
    Task Create();
    Task EnsureLoaded();
}
