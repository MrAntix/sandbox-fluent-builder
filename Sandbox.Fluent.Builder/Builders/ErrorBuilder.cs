using System;

namespace Sandbox.Fluent.Builder
{
    public class ErrorBuilder : ICompleteMethod
    {
        public CompleteBuilder Complete(Action action)
        {
            throw new NotImplementedException();
        }
    }
}