using System;

namespace Sandbox.FluentBuilder.Builders
{
    public interface ISetupMethod<T>
    {
        SetupBuilder<T> Setup(Action<T> action);
    }
}