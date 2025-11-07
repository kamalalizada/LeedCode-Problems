using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution191
{
    public int HammingWeight(int n)
    {
        List<int> list = new List<int>();
        while(n >= 1)
        {
            if(n%2 == 0)
            {
                list.Add(0);
                n = n / 2;
            }
            else
            {
                list.Add(1);
                n=(n-1)/2;
            }
        } 

        return list.Count(x=>x==1);

    }
}
