namespace SumOfUniqueElements;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3, 2 }); // output: [4]
        Test(solution, new int[] { 1, 1, 1, 1, 1 }); // output: [0]
        Test(solution, new int[] { 1, 2, 3, 4, 5 }); // output: [15]
    }

    static void Test(Solution solution, int[] nums)
    {
        int result = solution.SumOfUnique(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            frequencies[num] = frequencies.GetValueOrDefault(num) + 1;
        }

        return frequencies
            .Where(x => x.Value == 1)
            .Sum(x => x.Key);
    }
}