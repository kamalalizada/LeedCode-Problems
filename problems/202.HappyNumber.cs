using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution202
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            int sum = 0;

            while (n > 0)
            {
                int a = n % 10;
                sum += a * a;
                n /= 10;
            }

            n = sum;
        }

        return n == 1;
    }
}

