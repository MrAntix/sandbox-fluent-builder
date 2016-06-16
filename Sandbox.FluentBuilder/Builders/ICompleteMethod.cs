using System;

namespace Sandbox.FluentBuilder.Builders
{
    public interface ICompleteMethod<T>
    {
        CompleteBuilder<T> Complete(Action<T> action);
    }
}