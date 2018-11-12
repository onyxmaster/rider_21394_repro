using Xunit;

namespace rider_21394_repro
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.False(System.Diagnostics.Trace.UseGlobalLock);
        }
    }
}