using System;

namespace CalcOddEven
{
    public class FindOddOrEven
    {
        //public bool IsOddOrEven(int num)
        //{
        //    throw new NotImplementedException("Please create a test first ");
        //}

        public string IsOddOrEven(int startNum, int endNum)
        {
            var strNum = "";
            for ( int i = startNum; i <= endNum; i++)
            {
                //strNum += i; 

                if (i % 2 == 0)
                {
                    strNum += " even";
                }
                else
                {
                    strNum += " " + i;
                }
            }
            return strNum;
        }
    }
}
