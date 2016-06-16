using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class Builder
    {
        public static Builder<T> For<T>(T subject)
        {
            return new Builder<T>(subject);
        }
    }

    public class Builder<T> :
        BuilderBase<T>, ISetupMethod<T>, IErrorMethod<T>, ICompleteMethod<T>
    {
        public Builder(T subject) :
            base(subject, null, null, null)
        {
        }

        public SetupBuilder<T> Setup(Action<T> action)
        {
            return new SetupBuilder<T>(_subject, action);
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