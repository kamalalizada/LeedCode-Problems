using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution434
{
    public int CountSegments(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int count = 0;
        bool inSegment = false;

        foreach (char c in s)
        {
            if (c != ' ')
            {
                if (!inSegment)
                {
                    count++;
                    inSegment = true;
                }
            }
            else
            {
                inSegment = false;
            }
        }

        return count;
    }
}
