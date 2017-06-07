using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.dynamicprogramming.test
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void WordSearch_Search_Test_True()
        {
            // arrange
            var matrix = new char[,]
                {
                    { 'o', 'f', 'a', 's' },
                    { 'l', 'l', 'q', 'w' },
                    { 'z', 'o', 'w', 'k' }
                };
            var word = "follow";

            // act
            var actual = WordSearch.Search(matrix, word);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void WordSearch_Search_Test_False()
        {
            // arrange
            var matrix = new char[,]
                {
                    { 'o', 'f', 'a', 's' },
                    { 'l', 'l', 'q', 'w' },
                    { 'z', 'o', 'a', 'k' }
                };
            var word = "follow";

            // act
            var actual = WordSearch.Search(matrix, word);

            // assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void WordSearch_Search_Test_Backtracking()
        {
            // arrange
            var matrix = new char[,]
                {
                    { 'o', 'f', 'o', 'l' },
                    { 'l', 'l', 'c', 'l' },
                    { 'a', 'b', 'w', 'o' }
                };
            var word = "follow";

            // act
            var actual = WordSearch.Search(matrix, word);

            // assert
            Assert.IsTrue(actual);
        }
    }
}
