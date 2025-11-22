namespace LeedCode_Problems.problems;
using System.Collections.Generic;


public class Solution868
{
    public int BinaryGap(int n)
    {
        List<int> bits = new List<int>();

        while (n > 0)
        {
            bits.Add(n % 2);
            n = n / 2;
        }

        int last = -1;
        int maxGap = 0;

        for (int i = 0; i < bits.Count; i++)
        {
            if (bits[i] == 1)
            {
                if (last != -1)
                {
                    int gap = i - last;
                    if (gap > maxGap)
                        maxGap = gap;
                }

                last = i;
            }
        }

        return maxGap;
    }
}


