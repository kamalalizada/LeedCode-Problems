using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution205
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char cs = s[i];
            char ct = t[i];

            if (mapST.ContainsKey(cs))
            {
                if (mapST[cs] != ct)
                    return false;
            }
            else
            {
                mapST[cs] = ct;
            }

            if (mapTS.ContainsKey(ct))
            {
                if (mapTS[ct] != cs)
                    return false;
            }
            else
            {
                mapTS[ct] = cs;
            }
        }

        return true;
    }
}

