using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Components.Core.Tests;

[Collection("Collection")]
public sealed class CoreComponentTests : FixturedUnitTest
{
    public CoreComponentTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
