using Parsis.Authorization.Core.Type;

namespace Parsis.Authorization.Core.Contract;
public interface IDataSource
{
    string Parameter { get; set; }

    MethodType MethodType { get; set; }
}

