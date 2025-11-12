namespace LeedCode_Problems.problems;
public class Solution338
{
    public int[] CountBits(int n)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < n + 1; i++)
        {
            int num = i;
            int a = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    a += 1;
                    num = num / 2;


                }
                else
                {
                    a = a;
                    num = num / 2;
                }

            }
            list.Add(a);
        }

        return list.ToArray();

    }
}
