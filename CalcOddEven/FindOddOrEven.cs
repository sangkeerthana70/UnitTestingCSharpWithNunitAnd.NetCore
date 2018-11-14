using System;

namespace CalcOddEven
{
    public class FindOddOrEven
    {
        //public bool IsOddOrEven(int num)
        //{
        //    throw new NotImplementedException("Please create a test first ");
        //}

        public string IsOddOrEven(int [] numRange)
        {
            var strNum = "";
            for ( int i = 0; i < numRange.Length; i++)
            {
                //strNum += i; 

                if (numRange[i] % 2 == 0)
                {
                    
                    strNum += " even";
                    Console.WriteLine(numRange[i] + " Is Even");

                }
                else if (!(IsPrime(numRange[i])))
                {
                    Console.WriteLine(numRange[i] + " Is Odd");
                    strNum += " odd";
                }
                else
                {
                    Console.WriteLine(numRange[i] + " Is Prime");
                    strNum += " " + numRange[i];
                }

            }
            return strNum;
        }

        private bool IsPrime(int num)
        {

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + "Num is not prime: ");
                    return false;
                }

            }
            return true;
        }
    }
}
