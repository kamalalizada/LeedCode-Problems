using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {

        List<int> numbers1 = new List<int>();
        List<int> numbers2 = new List<int>();
        List<int> result = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            numbers1.Add(nums1[i]);
        }

        for (int i = 0;i < nums2.Length; i++)
        {
            numbers2.Add(nums2[i]);
        }

        foreach (int i in numbers1)
        {
            if (numbers2.Contains(i))
            {
                result.Add(i);
                numbers2.Remove(i);
            }

        } 

        return result.ToArray();



    }
}
