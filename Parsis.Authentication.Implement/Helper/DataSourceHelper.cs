using Parsis.Authorization.Core.Contract;
using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Implement.Helper;
public static class DataSourceHelper
{
    public static IEnumerable<T> HandleMethod<T>(this IEnumerable<T> items, IFieldAccess fieldAccess) where T : class , new()
    {
        IDataSource dataSource = fieldAccess.DataSource;

        var property = new T().GetType().GetProperty(dataSource.Parameter);
        //Check parameter is exists
        Type propertyType = property.PropertyType;

        switch (dataSource.MethodType)
        {
            case MethodType.Equal:
                items = items.Where(item => item.GetType().GetProperty(dataSource.Parameter).Equals(dataSource.Value));
                break;
            case MethodType.NotEqual:
                items = items.Where(item => !item.GetType().GetProperty(dataSource.Parameter).Equals(dataSource.Value));
                break;
            case MethodType.Contains:
                break;
            case MethodType.NotContains:
                break;
            case MethodType.Like:
                items = items.Where(item => dataSource.Value.ToString().Contains(item.GetType().GetProperty(dataSource.Parameter).ToString()));
                break;
            case MethodType.NotLike:
                items = items.Where(item => !dataSource.Value.ToString().Contains(item.GetType().GetProperty(dataSource.Parameter).ToString()));
                break;
            case MethodType.BiggerThan:
                items = items.Where(item => dataSource.Value.ToString().Contains(item.GetType().GetProperty(dataSource.Parameter).ToString()));
                break;
            case MethodType.BiggerThanOrEqual:

                //items = items.Where(item => dataSource.Value >= item.GetType().GetProperty(dataSource.Parameter));
                break;
            case MethodType.SmallerThan:
                break;
            case MethodType.SmallerThanOrEqual:
                break;
            case MethodType.None:
            default:
                break;
        }
        foreach (T item in items)
            yield return item;

    }


}
