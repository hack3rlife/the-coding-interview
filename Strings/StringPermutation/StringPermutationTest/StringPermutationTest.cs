using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.strings.test
{
    [TestClass]
    public class StringPermutationTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\permutations.csv", "permutations#csv", DataAccessMethod.Sequential)]
        public void StringPermutation_Permute_Test()
        {
            // arrange
            var input = TestContext.DataRow["input"].ToString();
            var expected = TestContext.DataRow["output"].ToString().ToString();

            // act
            var actual = StringPermutation.Permute(input);

            // assert
           Assert.AreEqual(expected, actual);
        }
    }
}
