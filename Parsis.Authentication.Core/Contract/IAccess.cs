using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;

public interface IAccess<Tid> : IEntity<Tid>
{
    /// <summary>
    /// 
    /// </summary>
    /// <Sample>
    /// EntryAdd
    /// </Sample>
    string Title
    {
        get;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <Sample>
    /// Action:Accounting:Entry:Add:Visible[AccountName:*,Debit:*,Credit:*]:Editable[AccountName:*,Debit:*,Credit:*]:DataSource[FiscalYears:*]
    /// </Sample>
    string Predicate
    {
        get;
    }

    IEnumerable<IAccessObject> AccessObject
    {
        get;
        init;
    }
}
