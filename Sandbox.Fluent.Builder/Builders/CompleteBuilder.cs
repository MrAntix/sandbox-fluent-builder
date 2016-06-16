using System;

namespace Sandbox.FluentBuilder.Builders
{
    public class CompleteBuilder<T> : BuilderBase<T>
    {
        public CompleteBuilder(Action<T> setup, Action<T> error, Action<T> complete) :
            base(setup, error, complete)
        {
        }
    }
}