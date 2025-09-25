using Microsoft.AspNetCore.Components;
using Soenneker.Utils.AtomicBool;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Soenneker.Quark;

/// <inheritdoc cref="ICoreComponent"/>
public abstract class CoreComponent : ComponentBase, ICoreComponent
{
    protected readonly AtomicBool Disposed = new();
    protected readonly AtomicBool AsyncDisposed = new();

    [Parameter]
    public virtual string? Id { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? Attributes { get; set; }

    protected virtual void OnDispose()
    {
    }

    protected virtual Task OnDisposeAsync() => Task.CompletedTask;

    public virtual void Dispose()
    {
        // Run sync cleanup once
        if (Disposed.TrySetTrue())
        {
            OnDispose();
        }
    }

    public virtual async ValueTask DisposeAsync()
    {
        // Run async cleanup once
        if (AsyncDisposed.TrySetTrue())
        {
            await OnDisposeAsync();
        }

        // Ensure the sync hook also runs once (if it hasn't already)
        if (Disposed.TrySetTrue())
        {
            // ReSharper disable once MethodHasAsyncOverload
            OnDispose();
        }
    }
}