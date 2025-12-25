using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution557
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');
        var result = new StringBuilder();

        foreach (var word in words)
        {
            var reversedWord = new string(word.Reverse().ToArray());
            result.Append(reversedWord).Append(' ');
        }

        return result.ToString().TrimEnd();
    }
}

