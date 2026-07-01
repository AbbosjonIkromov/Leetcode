namespace RunningSumOf1DArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3, 4 }); // Output: [1, 3, 6, 10]
        Test(solution, new int[] { 1, 1, 1, 1, 1 }); // Output: [1, 2, 3, 4, 5]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.RunningSum(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        List<int> sum = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                sum.Add(nums[i]);
            }
            else
            {
                sum.Add(sum[i - 1] + nums[i]);
            }
        }

        return sum.ToArray();
    }
}