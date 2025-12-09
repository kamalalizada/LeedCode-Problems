using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution724
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int total = 0;
            foreach (int n in nums)
                total += n;

            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int rightSum = total - leftSum - nums[i];

                if (leftSum == rightSum)
                    return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
