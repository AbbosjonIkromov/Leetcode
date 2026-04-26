namespace ContainsDuplicateII;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 0, 1, 1 }, 1); // output: true
        Test(solution, new int[] { 1, 2, 3, 1 }, 3); // output: true
        Test(solution, new int[] { 1, 2, 3, 1, 2, 3 }, 2); // output: false
    }

    static void Test(Solution solution, int[] nums, int k)
    {
        var result = solution.ContainsNearbyDuplicate(nums, k);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                int prevIndex = dict[nums[i]];

                if (i - prevIndex <= k)
                    return true;
            }

            dict[nums[i]] = i;
        }

        return false;
    }
}
