    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution367
{
    public bool IsPerfectSquare(int num)
    {

        int a =(int)Math.Sqrt(num);
        
        if(a*a == num)
            return true;
        else
            return false;


    }
}
