using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Soenneker.Atomics.ValueBools;

namespace Soenneker.Quark;

/// <inheritdoc cref="ICoreComponent"/>
public abstract class CoreComponent : ComponentBase, ICoreComponent
{
    protected ValueAtomicBool Disposed;
    protected ValueAtomicBool AsyncDisposed;

    [Parameter]
    public virtual string? Id { get; set; }

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? Attributes { get; set; }

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
