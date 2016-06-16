using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class ErrorBuilder<T> : BuilderBase<T>, ICompleteMethod<T>
    {
        public ErrorBuilder(Action<T> setup, Action<T> error) : 
            base(setup, error, null)
        {
        }

        public CompleteBuilder<T> Complete(Action<T> action)
        {
            return new CompleteBuilder<T>(_setup, _error, action);
        }
    }
}