using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class LightsOutTests
    {
        [TestMethod()]
        public void LightsOut_TurnOff_1x1_Test()
        {
            // arrange
            int[,] input =
                {
                    { 0 },
                    { 1 },
                };

            // act
            LightsOut.TurnOff(input);

            // arrange

        }

        [TestMethod()]
        public void LightsOut_TurnOff_2x2_Test()
        {
            // arrange
            int[,] input =
                {
                    { 1, 1 },
                    { 1, 0 },
                };

            // act
            LightsOut.TurnOff(input);

            // arrange

        }

        [TestMethod()]
        public void LightsOut_TurnOff_3x3_Test()
        {
            // arrange
            int[,] input =
                {
                    { 0, 1, 1 },
                    { 1, 1, 1 },
                    { 1, 0, 1 },
                };

            // act
            LightsOut.TurnOff(input);

            // arrange

        }

        [TestMethod()]
        public void LightsOut_TurnOff_AllOne_Test()
        {
            // arrange
            int[,] input =
                {
                    { 1, 1, 1 },
                    { 1, 1, 1 },
                    { 1, 1, 1 },
                };

            // act
            LightsOut.TurnOff(input);

            // assert
            int[,] expected =
                {
                     { 1, 1, 1 },
                    { 1, 1, 1 },
                    { 1, 1, 1 },
                };

            AreEqual(expected, input);
        }

        [TestMethod()]
        public void LightsOut_TurnOff_AllZero_Test()
        {
            // arrange
            int[,] input =
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                };

            // act
            LightsOut.TurnOff(input);

            // assert
            int[,] expected =
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                };

            AreEqual(expected, input);
        }

        private bool AreEqual(int[,] expected, int[,] actual)
        {
            int rlength = expected.GetLength(0);
            int clength = expected.GetLength(1);

            for (int i = 0; i < rlength; i++)
            {
                for (int j = 0; j < clength; j++)
                {
                    if (expected[i, j] != actual[i, j])
                        return false;
                }
            }

            return true;
        }

    }
}