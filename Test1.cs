using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzurePipeInvest
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {

        }

        [TestInitialize]
        public void TestInit()
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true, "test merge to master2");
        }


        [TestCleanup]
        public void TestClean()
        {

        }

        [ClassCleanup]
        public static void ClassClean()
        {

        }


    }
}
