using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsis.Authorization.Core.Contract
{
    public interface IEntityManager<TEntity, TType> : IObjectManager<TEntity> where TEntity : IEntity<TType>
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(string predicate);

        TEntity Find(string predicate);

        TEntity Find(TType id);

        bool TryParse(out IAccessObject accessObject);
    }
}
