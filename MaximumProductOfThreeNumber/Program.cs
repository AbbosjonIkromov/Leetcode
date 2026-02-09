using System.Collections.Immutable;

namespace MaximumProductOfThreeNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3 }); // output 6
        Test(solution, new int[] { 1, 2, 3, 4 }); // output 24
    }
    
    static void Test(Solution solution, int[] nums)
    {
        var result = solution.MaximumProduct(nums);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);

        int n = nums.Length;

        int product2 = nums[n - 1] * nums[n - 2] * nums[n - 3];

        int product1 = nums[0] * nums[1] * nums[n - 1];

        return Math.Max(product1, product2);
    }
}
