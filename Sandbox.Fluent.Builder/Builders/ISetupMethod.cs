using System;

namespace Sandbox.Fluent.Builder
{
    public interface ISetupMethod
    {
        SetupBuilder Setup(Action action);
    }
}