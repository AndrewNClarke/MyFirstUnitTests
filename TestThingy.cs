using Xunit;

namespace MyFirstUnitTests
{
    public class Class1
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void TestThingy(int i)
        {
            Thingy thingy = new Thingy(i);
            Assert.Equal<int>(i, thingy.x);
        }
    }
}