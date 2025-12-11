using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution628
{
    public int MaximumProduct(int[] nums)
    {
        int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;

        int min1 = int.MaxValue, min2 = int.MaxValue;

        foreach (int n in nums)
        {
            if (n > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = n;
            }
            else if (n > max2)
            {
                max3 = max2;
                max2 = n;
            }
            else if (n > max3)
            {
                max3 = n;
            }

            if (n < min1)
            {
                min2 = min1;
                min1 = n;
            }
            else if (n < min2)
            {
                min2 = n;
            }
        }

        int option1 = max1 * max2 * max3;
        int option2 = max1 * min1 * min2;

        return Math.Max(option1, option2);
    }
}

