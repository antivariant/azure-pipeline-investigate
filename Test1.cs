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
            Assert.IsTrue(false, "test message");
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
