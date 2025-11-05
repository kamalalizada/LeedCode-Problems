using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution405
{
    public string ToHex(int num)
    {
        if (num == 0) return "0";

        uint n = (uint)num;
        string hexChars = "0123456789abcdef";
        StringBuilder sb = new StringBuilder();

        while (n != 0)
        {
            int digit = (int)(n & 0xF);
            sb.Insert(0, hexChars[digit]);
            n >>= 4;
        }

        return sb.ToString();
    }
}
