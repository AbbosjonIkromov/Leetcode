namespace MaxConsecutiveOne;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, new int[] { 1, 1, 0, 1, 1, 1 }); // output: 3
        Test(solution, new int[] { 1, 0, 1, 1, 0, 1 }); // output: 2
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.FindMaxConsecutiveOnes(nums);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                maxCount = Math.Max(maxCount, count);
            }
            else
            {
                count = 0;
            }
        }

        return maxCount;
    }
}