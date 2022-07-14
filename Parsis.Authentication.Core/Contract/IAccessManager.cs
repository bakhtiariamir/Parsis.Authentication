namespace Parsis.Authorization.Core.Contract;
    public interface IAccessManager<TType> : IEntityManager<IAccess<TType>, IAccessObject, TType>
    {
    } 
