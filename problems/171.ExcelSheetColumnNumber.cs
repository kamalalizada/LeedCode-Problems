using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution171
{
    public int TitleToNumber(string columnTitle)
    {
        int result = 0;

        foreach (char c in columnTitle)
        {
            result = result * 26 + (c - 'A' + 1);
        }

        return result;
    }
}
