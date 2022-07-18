namespace Parsis.Authentication.Core.Contract
{
    public interface ICacheProvider<T>
    {
        T GetFromCache();
        void SetCache(T value);
        void ClearCache();
    }
}
 