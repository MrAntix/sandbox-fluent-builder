using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class SetupBuilder<T> :
        BuilderBase<T>, IErrorMethod<T>, ICompleteMethod<T>
    {
        public SetupBuilder(T subject, Action<T> setup) :
            base(subject, setup, null, null)
        {
        }

        public ErrorBuilder<T> Error(Action<T> action)
        {
            return new ErrorBuilder<T>(_subject, _setup, action);
        }

        public CompleteBuilder<T> Complete(Action<T> action)
        {
            return new CompleteBuilder<T>(_subject, _setup, _error, action);
        }
    }
}