using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        List<int> values1 = new List<int>();
        List<int> values2 = new List<int>();

        ListNode current1 = l1;
        while (current1 != null)
        {
            values1.Add(current1.val);
            current1 = current1.next;
        }

        ListNode current2 = l2;
        while (current2 != null)
        {
            values2.Add(current2.val);
            current2 = current2.next;
        }

        if (values1.Count < values2.Count)
        {
            var temp = values1;
            values1 = values2;
            values2 = temp;
        }

        List<int> result = new List<int>();
        int carry = 0;

        for (int i = 0; i < values1.Count; i++)
        {
            int v1 = values1[i];
            int v2 = i < values2.Count ? values2[i] : 0;
            int sum = v1 + v2 + carry;
            result.Add(sum % 10);
            carry = sum / 10;
        }

        if (carry > 0)
            result.Add(carry);

        return ConvertToListNode(result);
    }

    private ListNode ConvertToListNode(List<int> list)
    {
        if (list == null || list.Count == 0)
            return null;

        ListNode head = new ListNode(list[0]);
        ListNode current = head;

        for (int i = 1; i < list.Count; i++)
        {
            current.next = new ListNode(list[i]);
            current = current.next;
        }

        return head;
    }
}
