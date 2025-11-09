using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution234
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> arr = new List<int>();

        while (head != null)
        {
            arr.Add(head.val);
            head = head.next;
        }

        int left = 0;
        int right = arr.Count - 1;

        while (left < right)
        {
            if (arr[left] != arr[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
