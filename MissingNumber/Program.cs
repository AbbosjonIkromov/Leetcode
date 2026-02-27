namespace MissingNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 3, 0, 1 }); // [2]
        Test(solution, new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }); // [8]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.MissingNumber(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }
        return expectedSum - actualSum;
    }
}