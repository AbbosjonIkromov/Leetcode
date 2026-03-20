namespace LongestHarmoniousSubsequence;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 3, 2, 2, 5, 2, 3, 7 }); // output: [5]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.FindLHS(nums);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
                dict[num] = 0;

            dict[num]++;
        }

        int maxLength = 0;

        foreach (int key in dict.Keys)
        {
            if (dict.ContainsKey(key + 1))
            {
                int length = dict[key] + dict[key + 1];
                maxLength = Math.Max(maxLength, length);
            }
        }

        return maxLength;
    }
}