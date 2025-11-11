using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution263
{
    public bool IsUgly(int n)
    {
        if (n <= 0) return false;

        int[] primes = { 2, 3, 5 };
        foreach (int p in primes)
        {
            while (n % p == 0)
            {
                n /= p;
            }
        }

        return n == 1;
    }
}

