namespace LeedCode_Problems.problems;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {

        List<int> duplicates = new List<int>();
        for (var cur = head; cur != null; cur = cur.next)
        {
            duplicates.Add(cur.val);
        }

        duplicates.Sort();

        for (int i = 0; i < duplicates.Count - 1; i++)
        {
            if (duplicates[i] == duplicates[i + 1])
            {

                duplicates.RemoveAt(i + 1);
                i--;

            }
        }

        ListNode endResult = new ListNode(0);
        var newCur = endResult;
        foreach (var v in duplicates)
        {
            newCur = newCur.next = new ListNode(v);
        }


        return endResult.next;


    }
}

