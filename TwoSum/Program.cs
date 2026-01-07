namespace TwoSum;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        Test(solution, new int[] { 1, 2, 4, 5, 6, 7, 8 }, 15);  // output: [5, 6]
        Test(solution, new int[] { 2, 7, 11, 15 }, 9);          // output: [0, 1]
        Test(solution, new int[] { 3, 2, 4 }, 6);               // output: [1, 2]
    }

    static void Test(Solution solution, int[] nums, int target)
    {
        var result = solution.TwoSum(nums, target);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var numExpected = target - nums[i];
            if (map.ContainsKey(numExpected))
                return new int[] { map[numExpected], i };

            map[nums[i]] = i;
        }

        return new int[] { };
    }
}
