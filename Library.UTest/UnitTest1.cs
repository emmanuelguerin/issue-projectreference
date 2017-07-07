using NUnit.Framework;

namespace Library.UTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var c = new LClass();
            c.Do();
        }
    }
}
