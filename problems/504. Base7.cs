using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution504
{
    public string ConvertToBase7(int num)
    {
        if (num == 0) return "0";

        bool isNegative = num < 0;
        num = Math.Abs(num);

        string result = "";
        while (num > 0)
        {
            int remainder = num % 7;
            result = remainder.ToString() + result;
            num /= 7;
        }

        if (isNegative) result = "-" + result;
        return result;
    }
}
{
}
