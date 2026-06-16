namespace MaximizeSumOfArrayAfterKNegations;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, new int[] { 4, 2, 3 }, 1); // output: [5]
        Test(solution, new int[] { 3, -1, 0, 2 }, 3); // output: [6]
    }

    static void Test(Solution solution, int[] nums, int k)
    {
        var result = solution.LargestSumAfterKNegations(nums, k);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int LargestSumAfterKNegations(int[] nums, int k)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length && k > 0; i++)
        {
            if (nums[i] < 0)
            {
                nums[i] = -nums[i];
                k--;
            }
        }

        int sum = 0;
        int min = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            min = Math.Min(min, nums[i]);
        }

        if (k % 2 == 1)
        {
            sum -= 2 * min;
        }

        return sum;
    }
}