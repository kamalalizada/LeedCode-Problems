using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution575
{
    public int DistributeCandies(int[] candyType)
    {
        HashSet<int> set = new HashSet<int>(candyType);

        int differentTypes = set.Count;
        int maxEat = candyType.Length / 2;

        return Math.Min(differentTypes, maxEat);
    }
}

