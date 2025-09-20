using Soenneker.Quark.Components.Core.Abstract;
using Microsoft.AspNetCore.Components;

namespace Soenneker.Quark.Components.Core;

/// <inheritdoc cref="ICoreComponent"/>
public abstract class CoreComponent: ComponentBase, ICoreComponent
{
    [Parameter]
    public virtual string? Id { get; set; }
}
