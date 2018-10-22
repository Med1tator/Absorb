using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absorb.UnitTest.Sample
{
    public class Calculator
    {
        public int GetSumOfTwo(int num1, int num2)
        {
            return num1 + num2;
        }

        public int GetSum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
