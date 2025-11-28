using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution594
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        int maxLength = 0;

        foreach (int key in count.Keys)
        {
            if (count.ContainsKey(key + 1))
            {
                maxLength = Math.Max(maxLength, count[key] + count[key + 1]);
            }
        }

        return maxLength;
    }
}
