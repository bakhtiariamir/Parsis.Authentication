using Parsis.Authorization.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authentication.Implement.Manager
{
    public class AccessManager<TType> : IAccessManager<TType>
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void EnsureLoaded()
        {
            throw new NotImplementedException();
        }

        public IAccess<TType> Find(string predicate)
        {
            throw new NotImplementedException();
        }

        public IAccess<TType> Find(TType id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAccess<TType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAccess<TType>> GetAll(string predicate)
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public bool TryParse(out IAccessObject accessObject)
        {
            throw new NotImplementedException();
        }
    }
}
