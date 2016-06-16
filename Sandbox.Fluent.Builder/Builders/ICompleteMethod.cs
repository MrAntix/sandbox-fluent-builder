using System;

namespace Sandbox.Fluent.Builder
{
    public interface ICompleteMethod
    {
        CompleteBuilder Complete(Action action);
    }
}