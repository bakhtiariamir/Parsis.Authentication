using Parsis.Authorization.Core.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authorization.Core.Contract
{
    public interface IDataSource
    {
        string Parameter { get; set; }

        MethodType MethodType { get; set; }
    }
}
