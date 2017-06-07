using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class ShortestPathBinaryMazeTest
    {
        [TestMethod()]
        public void ShortestPathBinaryMaze_Find_Test()
        {
            // arrange
            var maze = new int[,] { {1, 0, 0, 0},
                                    {1, 1, 0, 1},
                                    {0, 1, 0, 0},
                                    {1, 1, 1, 1}
                                  };

            // act
            var condition = RatInAMaze.Find(maze);

            // assert
            Assert.IsTrue(condition);
        }
    }
}