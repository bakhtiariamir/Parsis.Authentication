using Parsis.Authorization.Core.Type;

namespace Parsis.Authentication.Core.Setup;
public class AccessConfig
{
    public IEnumerable<PathPattern> PathPatterns { get; set; }
}

public class PathPattern
{
    public AccessLevel AccessLevel { get; set; } = AccessLevel.Action;

    public string Pattern { get; set; } = "Controller:Action";
}

