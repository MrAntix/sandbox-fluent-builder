using System;

namespace Sandbox.Fluent.Builder.Builders
{
    public interface ISetupMethod
    {
        SetupBuilder Setup(Action action);
    }
}