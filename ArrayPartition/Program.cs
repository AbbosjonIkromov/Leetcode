namespace ArrayPartition;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 4, 3, 2 }); // 4
        Test(solution, new int[] { 6, 2, 6, 5, 1, 2 }); // 9
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.ArrayPairSum(nums);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);

        int sum = 0;
        for(int i = 0; i < nums.Length; i += 2)
        {
            sum += nums[i];
        }

        return sum;
    }
}
