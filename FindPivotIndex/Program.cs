namespace FindPivotIndex;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 7, 3, 6, 5, 6 }); // Output: 3
        Test(solution, new int[] { 1, 2, 3 }); // Output: -1
    }
    
    static void Test(Solution solution, int[] nums)
    {
        var result = solution.PivotIndex(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int totalsum = nums.Sum();
        int leftsum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftsum == totalsum - leftsum - nums[i])
                return i;
            leftsum += nums[i];
        }

        return -1;
    }
}