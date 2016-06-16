using Sandbox.FluentBuilder.Builders;
using Xunit;

namespace Sandbox.FluentBuilder
{
    public class Test
    {
        [Fact]
        public void build_1()
        {
            var subject = new TestSubject();

            Builder<TestSubject>.Create()
                .Setup(SetSetup)
                .Error(SetError)
                .Complete(SetComplete)
                .Build(subject);

            Assert.NotNull(subject.Setup);
            Assert.NotNull(subject.Error);
            Assert.NotNull(subject.Complete);
        }

        [Fact]
        public void build_2()
        {
            var subject = new TestSubject();

            Builder<TestSubject>.Create()
                .Error(SetError)
                .Complete(SetComplete)
                .Build(subject);

            Assert.Null(subject.Setup);
            Assert.NotNull(subject.Error);
            Assert.NotNull(subject.Complete);
        }

        [Fact]
        public void build_3()
        {
            var subject = new TestSubject();

            Builder<TestSubject>.Create()
                .Setup(SetSetup)
                .Complete(SetComplete)
                .Build(subject);

            Assert.NotNull(subject.Setup);
            Assert.Null(subject.Error);
            Assert.NotNull(subject.Complete);
        }

        [Fact]
        public void build_4()
        {
            var subject = new TestSubject();

            Builder<TestSubject>.Create()
                .Complete(SetComplete)
                .Build(subject);

            Assert.Null(subject.Setup);
            Assert.Null(subject.Error);
            Assert.NotNull(subject.Complete);
        }

        static void SetSetup(TestSubject s) => s.Setup = "SET";

        static void SetError(TestSubject s) => s.Error = "SET";

        static void SetComplete(TestSubject s) => s.Complete = "SET";
    }
}