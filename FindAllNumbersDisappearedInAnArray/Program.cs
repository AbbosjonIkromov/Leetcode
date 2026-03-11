using System.Collections.Generic;

namespace FindAllNumbersDisappearedInAnArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }); // Output: [5, 6]
        Test(solution, new int[] { 1, 1 });                   // Output: [2]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.FindDisappearedNumbers(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        HashSet<int> set = nums.ToHashSet();

        List<int> result = new List<int>();

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result.Add(i);
            }
        }

        return result;
    }
}