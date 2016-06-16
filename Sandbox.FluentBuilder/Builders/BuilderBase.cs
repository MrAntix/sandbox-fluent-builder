using System;

namespace Sandbox.FluentBuilder.Builders
{
    public abstract class BuilderBase<T>
    {
        protected readonly Action<T> _complete;
        protected readonly Action<T> _error;
        protected readonly Action<T> _setup;
        protected readonly T _subject;

        protected BuilderBase(
            T subject, Action<T> setup, Action<T> error, Action<T> complete)
        {
            _subject = subject;
            _setup = setup;
            _error = error;
            _complete = complete;
        }

        public void Build()
        {
            _setup?.Invoke(_subject);
            _error?.Invoke(_subject);
            _complete?.Invoke(_subject);
        }
    }
}