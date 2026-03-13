namespace SetMismatch;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 2, 4 }); // Output: [2, 3]
        Test(solution, new int[] { 1, 1 });       // Output: [1, 2]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.FindErrorNums(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        int duplicate = -1;
        int missing = -1;

        foreach (int num in nums)
        {
            if (!set.Add(num))
            {
                duplicate = num;
            }
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                missing = i;
                break;
            }
        }

        return new int[] { duplicate, missing };
    }
}