using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;

public interface IAccess : IObject
{
    /// <summary>
    /// 
    /// </summary>s
    /// <Sample>
    /// EntryAdd
    /// </Sample>
    string Title
    {
        get;
        set;
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
        set;
    }

    IEnumerable<IExtendedAccess> AccessObject
    {
        get;
        set;
    }
}
