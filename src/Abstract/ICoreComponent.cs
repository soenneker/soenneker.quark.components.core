using System;
using System.Threading.Tasks;

namespace Soenneker.Quark.Components.Core.Abstract;

/// <summary>
/// A Blazor core class for the Quark component.
/// </summary>
public interface ICoreComponent : IDisposable, IAsyncDisposable
{
    string? Id { get; set; }

    /// <summary>
    /// Disposes managed resources for the component. Implementations should be idempotent.
    /// </summary>
    new void Dispose();

    /// <summary>
    /// Asynchronously disposes managed resources for the component. Implementations should be idempotent.
    /// </summary>
    /// <returns>A task that completes when asynchronous disposal is finished.</returns>
    new ValueTask DisposeAsync();
}
