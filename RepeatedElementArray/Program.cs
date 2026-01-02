namespace RepeatedElementArray;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        Test(solution, new int[] { 1, 2, 3, 3 });
        Test(solution, new int[] { 2, 1, 2, 5, 3, 2 });
        Test(solution, new int[] { 5, 1, 5, 2, 5, 3, 5, 4 });
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.RepeatedNTimes(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
                return nums[i];

            if(i + 2 < nums.Length && nums[i] == nums[i + 2])
                return nums[i];
        }
        return nums[0];
    }
}
