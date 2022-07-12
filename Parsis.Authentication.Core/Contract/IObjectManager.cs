using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authorization.Core.Contract
{
    public interface IObjectManager<TObject> where TObject : IObject 
    {
        void Create();

        bool IsValid();

        void EnsureLoaded();
    }
}
