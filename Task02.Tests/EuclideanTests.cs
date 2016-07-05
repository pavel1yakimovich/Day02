using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task02.Euclidean;

namespace Task02.Tests
{
    [TestClass]
    public class EuclideanTests
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [DeploymentItem("Task02.Tests\\Cases.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                      "|DataDirectory|\\Cases.xml",
                      "Case",
                       DataAccessMethod.Sequential)]

        [TestMethod]
        public void SqrtN_PositiveTest()
        {
            int arg1 = int.Parse((string)TestContext.DataRow["arg1"]);
            int arg2 = int.Parse((string)TestContext.DataRow["arg2"]);
            int result = int.Parse((string)TestContext.DataRow["result"]);

            Assert.AreEqual(EuclideanAlgorithm(arg1, arg2), result);
        }
    }
}
