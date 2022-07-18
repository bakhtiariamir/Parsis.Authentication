using System;
using System.Net.Http.Headers;
using Parsis.Authentication.Implement.Model;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Helper;

public static class AuthenticationParser
{
    public static IEnumerable<IExtendedAccess> AccessParser(this string accessPredicate)
    {
        yield break ;
    }

    public static bool AccessPatternValid(this string accessPredicate)
    {
        return false;
    }

    public static bool PredicateMatcher(this string accessPredicate, string accessPredicatePattern)
    {
        return true;
    }

    public static IExtendedPermission PermissionParser(this  string permissionPredicate)
    {
        return null;
    }
}
