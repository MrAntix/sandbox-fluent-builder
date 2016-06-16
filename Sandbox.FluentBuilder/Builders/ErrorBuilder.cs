using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class ErrorBuilder<T> :
        BuilderBase<T>, ICompleteMethod<T>
    {
        public ErrorBuilder(T subject, Action<T> setup, Action<T> error) :
            base(subject, setup, error, null)
        {
        }

        public CompleteBuilder<T> Complete(Action<T> action)
        {
            return new CompleteBuilder<T>(_subject, _setup, _error, action);
        }
    }
}