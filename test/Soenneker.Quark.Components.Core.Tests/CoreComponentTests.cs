using Soenneker.Tests.HostedUnit;

namespace Soenneker.Quark.Components.Core.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CoreComponentTests : HostedUnitTest
{
    public CoreComponentTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
