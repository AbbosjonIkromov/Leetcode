namespace MinCostClimbingStairs;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 10, 15, 20 }); // output: 15
        Test(solution, new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }); // output: 6
    }

    static void Test(Solution solution, int[] cost)
    {
        var result = solution.MinCostClimbingStairs(cost);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int n = cost.Length;
        int first = cost[0];
        int second = cost[1];

        for (int i = 2; i < n; i++)
        {
            int current = cost[i] + Math.Min(first, second);

            first = second;
            second = current;
        }

        return Math.Min(first, second);
    }
}