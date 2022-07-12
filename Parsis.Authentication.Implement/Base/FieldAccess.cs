using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Base
{
    public class FieldAccess : IFieldAccess
    {
        public string Name { get; set; }

        public bool IsReadOnly { get; set; }

        public bool IsEditable { get; set; }

        public IDataSource DataSource { get; set; }
    }

}
