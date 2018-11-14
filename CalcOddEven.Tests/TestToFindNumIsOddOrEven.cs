using CalcOddEven;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class TestNumOddOrEven
    {        
        private readonly FindOddOrEven  _findOddEven;

        public TestNumOddOrEven()
        {
            _findOddEven = new FindOddOrEven();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void PrintNumsInRange()
        {
            int[] numRange = new int[] {1, 2, 3, 4, 5 };

            var expected = "12345";
            var actualResult = _findOddEven.IsOddOrEven(numRange);

            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void PrintWordEvenForEvenNums()
        {
            int[] numRange = new int[] { 2, 4, 6, 8, 10};

            var expected = " even even even even even";

            var actualResult = _findOddEven.IsOddOrEven(numRange);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void PrintWordEvenAndOddForGivenInput()
        {
            int[] numRange = new int[] { 2, 9, 4, 15};

            var expected = " even odd even odd";

            var actualResult = _findOddEven.IsOddOrEven(numRange);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }


    }


}

    
