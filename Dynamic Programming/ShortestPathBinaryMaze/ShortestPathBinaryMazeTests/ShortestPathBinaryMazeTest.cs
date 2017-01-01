using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShortestPathBinaryMaze.Test
{
    [TestClass()]
    public class ShortestPathBinaryMazeTest
    {
        [TestMethod()]
        public void ShortestPathBinaryMaze_Find_OnePath_Test()
        {
            // arrange
            var maze = new int[,] { {1, 0, 0, 0},
                                    {1, 1, 0, 1},
                                    {0, 1, 0, 0},
                                    {1, 1, 1, 1}
                                  };

            Point src = new Point(0, 0);
            Point dest = new Point(3, 1);

            // act
            var actual = ShortestPathBinaryMaze.Find(maze, src, dest);

            // assert
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ShortestPathBinaryMaze_Find_MultiplePaths_Test()
        {
            // arrange
            var maze = new int[,] { {1, 0, 0, 0},
                                    {1, 1, 0, 1},
                                    {0, 1, 1, 0},
                                    {1, 1, 1, 1}
                                  };

            Point src = new Point(0, 0);
            Point dest = new Point(3, 1);

            // act
            var actual = ShortestPathBinaryMaze.Find(maze, src, dest);

            // assert
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}