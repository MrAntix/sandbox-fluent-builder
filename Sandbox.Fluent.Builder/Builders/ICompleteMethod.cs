using System;

namespace Sandbox.Fluent.Builder.Builders
{
    public interface ICompleteMethod
    {
        CompleteBuilder Complete(Action action);
    }
}