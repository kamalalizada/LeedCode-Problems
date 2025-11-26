using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution415
{
    public string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;
        var result = new System.Text.StringBuilder();

        while (i >= 0 || j >= 0 || carry != 0)
        {
            int n1 = i >= 0 ? num1[i] - '0' : 0;
            int n2 = j >= 0 ? num2[j] - '0' : 0;
            int sum = n1 + n2 + carry;
            result.Insert(0, sum % 10); 
            carry = sum / 10;
            i--;
            j--;
        }

        return result.ToString();
    }
}

