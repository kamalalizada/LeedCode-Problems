using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution168
{
    public string ConvertToTitle(int columnNumber)
    {
        string result = "";

        while (columnNumber > 0)
        {
            columnNumber--;
            int remainder = columnNumber % 26;
            result = (char)(remainder + 'A') + result;
            columnNumber /= 26;
        }

        return result;
    }
}

