using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution728
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        List<int> result = new List<int>();

        for (int num = left; num <= right; num++)
        {
            int temp = num;
            bool isSelfDividing = true;

            while (temp > 0)
            {
                int digit = temp % 10;

                if (digit == 0 || num % digit != 0)
                {
                    isSelfDividing = false;
                    break;
                }

                temp /= 10;
            }

            if (isSelfDividing)
                result.Add(num);
        }

        return result;
    }
}
