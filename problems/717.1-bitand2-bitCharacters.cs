using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution717
{
    public bool IsOneBitCharacter(int[] bits)
    {
        int result = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == 0)
            {
                result = 1;
                
            }
            else if (bits[i] == 1)
            {
                result = 2;
                i = i + 1;
            }
        }

        if (result == 1) 
            return true;
        return false;
    }
}
