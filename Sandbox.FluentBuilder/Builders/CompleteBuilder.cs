using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class CompleteBuilder<T> :
        BuilderBase<T>
    {
        public CompleteBuilder(T subject, Action<T> setup, Action<T> error, Action<T> complete) :
            base(subject, setup, error, complete)
        {
        }
    }
}