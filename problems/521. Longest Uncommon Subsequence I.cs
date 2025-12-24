using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution521
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        return Math.Max(a.Length, b.Length);
    }
}

