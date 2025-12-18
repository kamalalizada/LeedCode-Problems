using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution349
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> intersection = new HashSet<int>();

        foreach (int num in nums2)
        {
            if (set1.Contains(num))
            {
                intersection.Add(num);
            }
        }

        return new List<int>(intersection).ToArray();
    }
}
