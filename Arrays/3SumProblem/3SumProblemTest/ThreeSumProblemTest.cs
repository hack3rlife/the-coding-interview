using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.Test
{
    [TestClass ()]
    public class ThreeSumProblemTest
    {
        [TestMethod ()]
        public void ThreeSumProblem_FindTriplets_Test()
        {
            // arrange
            var input = new int[] { 1, 5, 3, 4, 7, 7, 8, 9, 10, 23 };
            int n = 17;

            // act
            ThreeSumProblem.FindTriplets (input, n);

            // assert
        }
    }
}