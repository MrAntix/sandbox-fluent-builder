namespace Sandbox.Fluent.Builder
{
    public class Test
    {
        public void build()
        {
            new Builder()
                .Setup(() => { })
                .Error(() => { })
                .Complete(() => { });

            new Builder()
                .Error(() => { })
                .Complete(() => { });

            new Builder()
                .Setup(() => { })
                .Complete(() => { });

            new Builder()
                .Complete(() => { });

            new Builder()
                .Setup(() => { })
                .Setup(() => { });

            new Builder()
                .Setup(() => { })
                .Error(() => { })
                .Error(() => { });

        }
    }
}