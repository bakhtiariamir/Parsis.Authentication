using System;
using System.Net.Http.Headers;
using Parsis.Authentication.Implement.Model;
using Parsis.Authorization.Core.Contract;

namespace Parsis.Authentication.Implement.Helper;

public static class AuthenticationParser
{
    public static IAccessObject AccessParser(this string accessPredicate)
    {
        return new AccessObject();
    }

    public static bool AccessPatternValid(this string accessPredicate)
    {
        return false;
    }

    public static bool PredicateMatcher(this string accessPredicate, string accessPredicatePattern)
    {
        return true;
    }

    public static IPermissionObject PermissionParser(this  string permissionPredicate)
    {
        return null;
    }
}
