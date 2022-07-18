using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Implement.Base
{
    public class DataSource : IDataSource
    {
        public string Parameter { get; set; }
        public MethodType MethodType { get; set; }
        public object Value { get; set; }
    }

}
