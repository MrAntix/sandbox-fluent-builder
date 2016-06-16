using System;

namespace Sandbox.FluentBuilder.Builders
{
    public interface IErrorMethod<T>
    {
        ErrorBuilder<T> Error(Action<T> action);
    }
}