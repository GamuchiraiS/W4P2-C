using Microsoft.VisualStudio.TestTools.UnitTesting;
using P2;
using System;

namespace DuplicateUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DupNumTests1()
        {
            //Arrange 
            int expectedAmount = 2;
            int actualAmount;
            int[] valueArrTest = { 50, 50, 20, 20, 4, 60, 88, 7, 9, 1 };
            Duplicate duplicate = new Duplicate(valueArrTest);

            //Act 
            actualAmount = duplicate.AmountDupNums(valueArrTest);

            //Assert 
            Assert.IsTrue((actualAmount == expectedAmount), "Amount not calculated properly");

        }

        [TestMethod]
        public void DupNumTests2()
        {
            //Arrange 
            int expectedAmount = 1;
            int actualAmount;
            int[] valueArrTest = { 50, 5, 20, 20, 4, 60, 88, 7, 9, 1 };
            Duplicate duplicate = new Duplicate(valueArrTest);

            //Act 
            actualAmount = duplicate.AmountDupNums(valueArrTest);

            //Assert 
            Assert.IsTrue((actualAmount == expectedAmount), "Amount not calculated properly");

        }

        [TestMethod]
        public void DupNumTests3()
        {
            //Arrange 
            int expectedAmount = 4;
            int actualAmount;
            int[] valueArrTest = { 50, 50, 20, 20, 4, 4, 88, 88, 9, 1 };
            Duplicate duplicate = new Duplicate(valueArrTest);

            //Act 
            actualAmount = duplicate.AmountDupNums(valueArrTest);

            //Assert 
            Assert.IsTrue((actualAmount == expectedAmount), "Amount not calculated properly");

        }
    }
}
