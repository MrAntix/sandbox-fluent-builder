using System;

namespace Sandbox.FluentBuilder.Builders
{
    public abstract class BuilderBase<T>
    {
        protected readonly Action<T> _complete;
        protected readonly Action<T> _error;
        protected readonly Action<T> _setup;

        protected BuilderBase(Action<T> setup, Action<T> error, Action<T> complete)
        {
            _setup = setup;
            _error = error;
            _complete = complete;
        }

        public void Build(T subject)
        {
            _setup?.Invoke(subject);
            _error?.Invoke(subject);
            _complete?.Invoke(subject);
        }
    }
}