//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberCollection;

namespace NumberCollectionTest
{
    [TestClass]
    public class NumberCollTests
    {
        private NumberColl numberColl;

        [TestInitialize]
        public void Setup()
        {
            numberColl = new NumberColl(new int[] { 1, 2, 3, 4, 5 });
        }

        [TestMethod]
        public void GetAverage_ReturnsCorrectAverage()
        {
            double expected = 3.0;
            double result = numberColl.GetAverage();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSum_ReturnsCorrectSum()
        {
            int expected = 15;
            int result = numberColl.GetSum();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMax_ReturnsCorrectMax()
        {
            int expected = 5;
            int result = numberColl.GetMax();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMin_ReturnsCorrectMin()
        {
            int expected = 1;
            int result = numberColl.GetMin();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Contains_ReturnsTrueIfNumberExists()
        {
            int number = 3;
            bool result = numberColl.Contains(number);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Contains_ReturnsFalseIfNumberDoesNotExist()
        {
            int number = 10;
            bool result = numberColl.Contains(number);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Count_ReturnsCorrectCount()
        {
            int expectedCount = 5;
            int result = numberColl.Count();
            Assert.AreEqual(expectedCount, result);
        }
    }
}