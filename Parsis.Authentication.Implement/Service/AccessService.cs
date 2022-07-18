using Parsis.Authentication.Core.Contract;
using Parsis.Authentication.Implement.Helper;
using Parsis.Authentication.Implement.Model;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Manager
{
    public class AccessService : IAccessService, IEnsureLoadedService
    {
        private readonly IAccessCacheProvider _accessCacheProvider;

        public AccessService(IAccessCacheProvider accessCacheProvider)
        {
            _accessCacheProvider = accessCacheProvider;
        }

        public virtual Task EnsureLoaded()
        {
            return Task.CompletedTask;
        }

        public async Task<IAccess> Get(string predicate)
        {
            var accesses = _accessCacheProvider.GetFromCache();
            if (accesses == null) await EnsureLoaded();

            var isValidPredicate = await Task.Run(predicate.AccessPatternValid);
            if (isValidPredicate)
            {
                var access = accesses.FirstOrDefault(item => item.Value.Predicate.Equals(predicate)).Value;
                if (access == null)
                    throw new Exception("Not Found");
                else 
                {
                    access.AccessObject = await Parse(access.Predicate);
                    return access;
                }

            }
            else
            {
                throw new Exception("Bad Request");
            }
        }

        public async IAsyncEnumerable<IAccess> GetAll()
        {
            var accesses = _accessCacheProvider.GetFromCache();
            if (accesses == null) await EnsureLoaded();
            foreach (var access in accesses.Values)
            {
                access.AccessObject = await Parse(access.Predicate);
                yield return access;
            }

        }

        public async IAsyncEnumerable<IAccess> GetAll(string predicate)
        {
            var isValidPredicate = await Task.Run(predicate.AccessPatternValid);
            var accesses = _accessCacheProvider.GetFromCache();
            if (accesses == null) await EnsureLoaded();
            if (isValidPredicate)
            {
                foreach (var access in accesses.Values)
                {
                    if (access.Predicate.PredicateMatcher(predicate))
                    {
                        access.AccessObject = await Parse(access.Predicate);
                        yield return access;
                    }
                }
            }
            else
            {
                throw new Exception("Bad Request");
            }
        }

        public async Task<bool> IsMatch(string predicate)
        {
            await foreach (var item in GetAll())
                return predicate.Equals(item.Predicate);

            return false;
        }

        public async Task<IEnumerable<IExtendedAccess>> Parse(string predicate) => (await IsMatch(predicate)) ? await Task.Run(predicate.AccessParser) : null;

        public async Task<IAccess> Create(string predicate)
        {
            if (string.IsNullOrEmpty(predicate))
                return await Get(predicate);
            return new Access();
        }
    }
}
