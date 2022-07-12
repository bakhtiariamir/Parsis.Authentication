using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authorization.Core.Type
{
    public enum MethodType
    {
        None = 0,
        Equal = 1,
        NotEqual = 2,
        Contains = 3,
        NotContains = 4,
        Like = 5,
        NotLike = 6,
        BiggerThan = 7,
        BiggerThanOrEqual = 8,
        SmallerThan = 9,
        SmallerThanOrEqual = 10
    }
}
