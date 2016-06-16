using System;

namespace Sandbox.Fluent.Builder
{
    public class Builder : ISetupMethod, IErrorMethod, ICompleteMethod
    {
        public SetupBuilder Setup(Action action)
        {
            throw new NotImplementedException();
        }

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