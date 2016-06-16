using System;

namespace Sandbox.Fluent.Builder.Builders
{
    public class SetupBuilder: BuilderBase, IErrorMethod, ICompleteMethod
    {
        public ErrorBuilder Error(Action action)
        {
            throw new NotImplementedException();
        }

        public CompleteBuilder Complete(Action action)
        {
            throw new NotImplementedException();
        }
    }
}