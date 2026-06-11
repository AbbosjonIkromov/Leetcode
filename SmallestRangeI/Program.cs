namespace SmallestRangeI;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1 }, 0); // Output: 0
        Test(solution, new int[] { 0, 10 }, 0); // Output: 10
    }

    static void Test(Solution solution, int[] nums, int k)
    {
        int result = solution.SmallestRangeI(nums, k);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        int min = nums.Min();
        int max = nums.Max();

        return Math.Max(0, max - min - 2 * k);
    }
}