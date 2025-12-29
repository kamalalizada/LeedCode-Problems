using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        long windowSum = 0;


        for (int i = 0; i < k; i++)
            windowSum += nums[i];

        long maxSum = windowSum;

        for (int i = k; i < nums.Length; i++)
        {
            windowSum += nums[i] - nums[i - k];
            if (windowSum > maxSum) maxSum = windowSum;
        }

        return (double)maxSum / k;
    }
}

