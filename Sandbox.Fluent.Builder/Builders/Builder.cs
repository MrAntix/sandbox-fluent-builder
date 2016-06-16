using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class Builder<T> : BuilderBase<T>, ISetupMethod<T>, IErrorMethod<T>, ICompleteMethod<T>
    {
        public Builder() : base(null, null, null)
        {
        }

        public SetupBuilder<T> Setup(Action<T> action)
        {
            return new SetupBuilder<T>(action);
        }

        public ErrorBuilder<T> Error(Action<T> action)
        {
            return new ErrorBuilder<T>(_setup, action);
        }

        public CompleteBuilder<T> Complete(Action<T> action)
        {
            return new CompleteBuilder<T>(_setup, _error, action);
        }

        public static Builder<T> Create()
        {
            return new Builder<T>();
        }
    }
}