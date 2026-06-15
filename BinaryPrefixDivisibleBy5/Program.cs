namespace BinaryPrefixDivisibleBy5;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 0, 1, 1 }); // Expected output: [true, false, false]
        Test(solution, new int[] { 1, 0, 1 }); // Expected output: [false, false, true]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.PrefixesDivBy5(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        List<bool> result = new List<bool>();
        int prefix = 0;

        foreach (int num in nums)
        {
            prefix = (prefix * 2 + num) % 5;
            result.Add(prefix == 0);
        }

        return result;
    }
}
