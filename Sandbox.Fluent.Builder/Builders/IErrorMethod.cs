using System;

namespace Sandbox.Fluent.Builder.Builders
{
    public interface IErrorMethod
    {
        ErrorBuilder Error(Action action);
    }
}