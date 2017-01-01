using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace com.hack3rlife.arrays.test
{
    [TestClass()]
    public class StairCaseUnitTest
    {
        [TestMethod()]
        public void StairCase_DrawRight_Test()
        {
            //arrange
            int n = 6;

            //act
            var actual = StairCase.DrawRight(n);

            //assert
            string[,] expected =
            {
                {"#",null,null,null,null,null},
                {"#","#" ,null,null,null,null},
                {"#","#" ,"#" ,null,null,null},
                {"#","#" ,"#" ,"#" ,null,null},
                {"#","#" ,"#" ,"#" ,"#" ,null},
                {"#","#" ,"#" ,"#" ,"#" ,"#"}
            };

            CollectionAssert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void StairCase_DrawLeft_Test()
        {
            //arrange
            int n = 6;
            //act
            var actual = StairCase.DrawLeft(n);

            string[,] expected =
            {
                {null,null,null,null,null,"#"},
                {null,null,null,null,"#" ,"#"},
                {null,null,null, "#","#" ,"#"},
                {null,null,"#" ,"#" ,"#" ,"#"},
                {null,"#" ,"#" ,"#" ,"#" ,"#",},
                {"#" ,"#" ,"#" ,"#" ,"#" ,"#"}
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}