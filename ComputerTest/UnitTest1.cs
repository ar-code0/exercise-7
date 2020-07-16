using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputerNS;

namespace ComputerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void Test1() // Computer's constructor works
        {
            Computer test_computer = new Computer("Mac", false, 1000.99);
            Assert.AreEqual("Mac", test_computer.name);
        }
    }
}
