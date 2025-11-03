using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution392
{
    public bool IsSubsequence(string s, string t)
    {
        int i = 0;
        int j = 0;

        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
                i++;
            j++;
        }

        return i == s.Length;
    }
}

