namespace GetMaximumInGeneratedArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 7); // Output: [3]
        Test(solution, 2); // Output: [1]
    }

    static void Test(Solution solution, int n)
    {
        int result = solution.GetMaximumGenerated(n);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int GetMaximumGenerated(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        int[] nums = new int[n + 1];
        nums[0] = 0;
        nums[1] = 1;
        int max = 1;
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                nums[i] = nums[i / 2];
            }
            else
            {
                nums[i] = nums[i / 2] + nums[i / 2 + 1];
            }
            max = Math.Max(max, nums[i]);
        }
        return max;
    }
}
