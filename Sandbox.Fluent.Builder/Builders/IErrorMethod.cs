using System;

namespace Sandbox.Fluent.Builder
{
    public interface IErrorMethod
    {
        ErrorBuilder Error(Action action);
    }
}