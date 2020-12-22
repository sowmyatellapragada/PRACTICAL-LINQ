using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQ;

namespace LINQ
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            var listBuilder = new Builder();

            var result = listBuilder.BuildIntegerSequence();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            var listBuilder = new Builder();

            var result = listBuilder.BuildStringSequence();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CompareSequenceTest()
        {
            var listBuilder = new Builder();
            var result = listBuilder.CompareSequences();

            foreach (var item in result)
                TestContext.WriteLine(item.ToString());

            Assert.IsNotNull(result);
        }
    }
}