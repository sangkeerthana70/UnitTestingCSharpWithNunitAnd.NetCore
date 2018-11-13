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
            int startRange = 1;
            int endRange = 5;

            var expected = "12345";
            var actualResult = _findOddEven.IsOddOrEven(startRange, endRange);

            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void PrintWordEvenForEvenNums()
        {
            int startRange = 1;
            int endRange = 10;

            var expected = " 1 even 3 even 5 even 7 even 9 even";

            var actualResult = _findOddEven.IsOddOrEven(startRange, endRange);
            Console.WriteLine(actualResult);
            Assert.AreEqual(expected, actualResult);
        }
    }


}

    
