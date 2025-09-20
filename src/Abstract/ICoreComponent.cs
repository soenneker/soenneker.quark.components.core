using System;

namespace Soenneker.Quark.Components.Core.Abstract;

/// <summary>
/// A Blazor core class for the Quark component.
/// </summary>
public interface ICoreComponent : IDisposable, IAsyncDisposable
{
    string? Id { get; set; }
}
