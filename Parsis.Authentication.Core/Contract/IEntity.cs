using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authorization.Core.Contract;

public interface IEntity<TType> : IObject
{
    TType Id { get; }
}

public interface IObject
{

}

