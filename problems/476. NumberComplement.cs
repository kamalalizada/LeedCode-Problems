using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution476
{
    public int FindComplement(int num)
    {
        List<int> result = new List<int>();
        while (num > 0)
        {
            if (num % 2 == 0)
                result.Add(1);
            else
                result.Add(0);

            num /= 2;
        }

        int resultNum = 0;
        for (int i = 0; i < result.Count; i++)
        {
            resultNum += result[i] << i;
        }

        return resultNum;
    }
}

