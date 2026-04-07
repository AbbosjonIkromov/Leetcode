namespace MonotonicArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 2, 3 }); // output: true
        Test(solution, new int[] { 6, 5, 4, 4 }); // output: true
        Test(solution, new int[] { 1, 3, 2 }); // output: false
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.IsMonotonic(nums);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        bool increasing = true;
        bool decreasing = true;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] < nums[i + 1])
                decreasing = false;
            else if (nums[i] > nums[i + 1])
                increasing = false;
        }

        return increasing || decreasing;
    }
}