namespace TimeNeededToBuyTicket;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 2, 3, 2 }, 2); // Expected output: [6]
        Test(solution, new int[] { 5, 1, 1, 1 }, 0); // Expected output: [8]
    }

    static void Test(Solution solution, int[] tickets, int k)
    {
        int result = solution.TimeRequiredToBuy(tickets, k);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int result = 0;

        for (int i = 0; i < tickets.Length; i++)
        {
            if (i <= k)
            {
                result += Math.Min(tickets[i], tickets[k]);
            }
            else
            {
                result += Math.Min(tickets[i], tickets[k] - 1);
            }
        }

        return result;
    }
}
