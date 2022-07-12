using Parsis.Authorization.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authentication.Implement.Base
{
    public class BaseEntity<TType> : BaseObject, IEntity<TType>
    {
        public TType Id { get;  }

        public BaseEntity(TType id) =>  Id = id;
    }

    public class BaseObject : IObject
    {

    }
}
