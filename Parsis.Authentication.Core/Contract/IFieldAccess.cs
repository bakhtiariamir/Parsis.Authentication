namespace Parsis.Authorization.Core.Contract
{
    public interface IFieldAccess
    {
        string Name { get; }

        bool IsReadOnly { get; }

        bool IsEditable { get; }

        IDataSource DataSource { get; }
    }
}
