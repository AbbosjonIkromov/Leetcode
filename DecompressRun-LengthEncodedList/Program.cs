namespace DecompressRun_LengthEncodedList;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3, 4 }); // Output: [2, 4, 4, 4]
        Test(solution, new int[] { 1, 1, 2, 3 }); // Output: [1, 3, 3]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.DecompressRLElist(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] DecompressRLElist(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i += 2)
        {
            int freq = nums[i];
            int val = nums[i + 1];
            for (int j = 0; j < freq; j++)
            {
                result.Add(val);
            }
        }
        return result.ToArray();
    }
}