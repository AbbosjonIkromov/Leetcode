namespace SingleNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 2, 1, 1, 2, 4 }); // output 4
        Test(solution, new int[] { 4 , 1, 2, 3, 4, 2, 1 }); // output 3
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.SingleNumber(nums);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;

        foreach (int num in nums)
            result ^= num;

        return result;
    }
}
