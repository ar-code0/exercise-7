using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnologyNS;

namespace TechnologyTest
{
    [TestClass]
    public class ComputerTest
    {
        Computer test_computer;


        [TestInitialize]
        Computer test_computer = new Computer("Mac", false, 1000.99);

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        [TestMethod]
        public void Test1() // Computer's constructor works
        {

            Assert.AreEqual("Mac", test_computer.name);
        }
    }
}
