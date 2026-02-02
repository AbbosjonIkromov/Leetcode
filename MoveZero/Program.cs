namespace MoveZero;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 0, 1, 0, 3, 12 }); // output [1,3,12,0,0]
        Test(solution, new int[] { 0 }); // output [0]

    }
    static void Test(Solution solution, int[] nums)
    {
        solution.MoveZeroes(nums);
        Console.WriteLine($"[{string.Join(",", nums)}]");
    }
}

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int lastNonZeroFoundAt = 0;
        for (int current = 0; current < nums.Length; current++)
        {
            if (nums[current] != 0)
            {
                // Swap elements
                int temp = nums[lastNonZeroFoundAt];
                nums[lastNonZeroFoundAt] = nums[current];
                nums[current] = temp;
                lastNonZeroFoundAt++;
            }
        }
    }
}
