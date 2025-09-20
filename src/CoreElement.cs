using Microsoft.AspNetCore.Components;
using Soenneker.Quark.Components.Core.Abstract;

namespace Soenneker.Quark.Components.Core;

///<inheritdoc cref="ICoreElement"/>
public abstract class CoreElement : CoreComponent, ICoreElement
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}