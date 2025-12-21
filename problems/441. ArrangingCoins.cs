namespace LeedCode_Problems.problems;
public class Solution441
{

    public int ArrangeCoins(int n)
    {

        long sum = 1;
        int result = 1;
        while (true)
        {
            if (sum < n)
            {
                sum = sum + result + 1;
                result = result + 1;
            }

            else if (sum == n)
                return result;

            else
            {
                return result - 1;
            }

        }

    }
}



