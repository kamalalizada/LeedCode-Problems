using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution645
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int[] count = new int[n + 1];
        int duplicate = -1, missing = -1;

        foreach (int num in nums)
        {
            count[num]++;
        }

        for (int i = 1; i <= n; i++)
        {
            if (count[i] == 2)
            {
                duplicate = i;
            }
            else if (count[i] == 0)
            {
                missing = i;
            }
        }

        return new int[] { duplicate, missing };
    }
}

