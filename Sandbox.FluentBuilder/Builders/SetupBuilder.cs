using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class SetupBuilder<T> :
        BuilderBase<T>, IErrorMethod<T>, ICompleteMethod<T>
    {
        public SetupBuilder(Action<T> setup) :
            base(setup, null, null)
        {
        }

        public ErrorBuilder<T> Error(Action<T> action)
        {
            return new ErrorBuilder<T>(_setup, action);
        }

        public CompleteBuilder<T> Complete(Action<T> action)
        {
            return new CompleteBuilder<T>(_setup, _error, action);
        }
    }
}