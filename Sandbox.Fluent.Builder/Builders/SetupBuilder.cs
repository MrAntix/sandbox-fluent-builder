using System;

namespace Sandbox.Fluent.Builder
{
    public class SetupBuilder: IErrorMethod, ICompleteMethod
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