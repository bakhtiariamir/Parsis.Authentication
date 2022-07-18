namespace Parsis.Authorization.Core.Contract;
public interface IExtendedObjectService<TObject> where TObject : IExtendedObject
{
    Task<TObject> Create();
}
