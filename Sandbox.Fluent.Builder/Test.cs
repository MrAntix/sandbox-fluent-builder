namespace Sandbox.Fluent.Builder
{
    public class Test
    {
        public void build()
        {
            new Builders.Builder()
                .Setup(() => { })
                .Error(() => { })
                .Complete(() => { })
                .Build();

            new Builders.Builder()
                .Error(() => { })
                .Complete(() => { })
                .Build();

            new Builders.Builder()
                .Setup(() => { })
                .Complete(() => { })
                .Build();

            new Builders.Builder()
                .Complete(() => { })
                .Build();

            new Builders.Builder()
                .Setup(() => { })
                .Setup(() => { });

            new Builders.Builder()
                .Setup(() => { })
                .Error(() => { })
                .Error(() => { });

        }
    }
}