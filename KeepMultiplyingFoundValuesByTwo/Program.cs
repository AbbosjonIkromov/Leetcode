namespace KeepMultiplyingFoundValuesByTwo;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 5, 3, 6, 1, 12 }, 3); // Output: [24]
        Test(solution, new int[] { 2, 7, 9 }, 4); // Output: [4]
    }

    static void Test(Solution solution, int[] nums, int original)
    {
        int result = solution.FindFinalValue(nums, original);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        HashSet<int> set = new HashSet<int>(nums);
        while (set.Contains(original))
        {
            original *= 2;
        }
        return original;
    }
}
