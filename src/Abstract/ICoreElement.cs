using Microsoft.AspNetCore.Components;

namespace Soenneker.Quark.Components.Core.Abstract;

public interface ICoreElement
{
    RenderFragment? ChildContent { get; set; }
}