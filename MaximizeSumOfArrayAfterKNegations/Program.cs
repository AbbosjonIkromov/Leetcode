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
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0 && k > 0)
            {
                sum -= nums[i];
                k--;
            }
            else
            {
                sum += nums[i];
            }
        }

        if (k > 0 && nums[0] >= 0)
        {
            sum -= 2 * nums[0];
        }
        return sum;
    }
}