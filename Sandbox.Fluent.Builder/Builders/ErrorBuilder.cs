using System;

namespace Sandbox.Fluent.Builder.Builders
{
    public class ErrorBuilder : BuilderBase, ICompleteMethod
    {
        public CompleteBuilder Complete(Action action)
        {
            throw new NotImplementedException();
        }
    }
}