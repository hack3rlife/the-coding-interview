using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.datastructures.test
{
    [TestClass()]
    public class BinaryTreeToListTest
    {
        [TestMethod()]
        public void ToListTest()
        {
            //arrnge
            IList<int> expected = new int[] { 1, 2, 3, 4, 5, 6 };

            //act
            var bt = expected.ToBinaryTreeInLevels();
            bt.Display();

            //assert
            int i = 0;
            foreach (var actual in bt.InLevelsEnumerable)
            {
                Assert.AreEqual<int>(expected[i++], actual);
            }
        }
    }
}