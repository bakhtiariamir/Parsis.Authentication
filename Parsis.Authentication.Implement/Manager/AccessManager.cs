using System.Runtime.CompilerServices;
using Parsis.Authorization.Core.Contract;
using Parsis.Authentication.Implement.Helper;
using Parsis.Authentication.Implement.Model;

namespace Parsis.Authentication.Implement.Manager
{
    public abstract class AccessManager<TType> : IAccessManager<TType>
    {
        public abstract Task Create();

        public abstract Task EnsureLoaded();

        public abstract Task<IAccess<TType>> Find(string predicate);

        public abstract Task<IAccess<TType>> Find(TType id);

        public abstract Task Save(IAccess<TType> entity);

        public abstract Task Delete(IAccess<TType> entity);

        public abstract Task Delete(TType id);
        public abstract Task<IEnumerable<IAccess<TType>>> GetAll();

        public async IAsyncEnumerable<IAccess<TType>> GetAll(string predicate)
        {
            var isValidPredicate = await Task.Run(predicate.AccessPatternValid);
            var accesses = await GetAll();
            if (!isValidPredicate)
                foreach (var access in accesses)
                {
                    if (access.Predicate.PredicateMatcher(predicate))
                    {
                        yield return access;
                    }
                }
        }

        public async Task<bool> IsMatch(string predicate) => (await GetAll()).Any(item => predicate.Equals(item.Predicate));
        
        public async Task<IAccessObject> Parse(string predicate) => (await IsMatch(predicate)) ? await Task.Run(predicate.AccessParser) : new AccessObject();

    }
}
