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
        if (nums == null || nums.Length == 0) return 0;

        var freq = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            if (freq.ContainsKey(n)) freq[n]++;
            else freq[n] = 1;
        }

        int best = 0;
        foreach (var kv in freq)
        {
            int x = kv.Key;
            if (freq.ContainsKey(x + 1))
            {
                best = Math.Max(best, freq[x] + freq[x + 1]);
            }
        }

        return best;
    }
}
