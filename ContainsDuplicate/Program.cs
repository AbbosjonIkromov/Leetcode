namespace ContainsDuplicate;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }); // output false;
        Test(solution, new int[] { 1, 2, 3, 4, 4 }); // output true
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.ContainsDuplicate(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> visited = new HashSet<int>();

        foreach(int num in nums)
        {
            if (visited.Contains(num)) return true;

            visited.Add(num);
        }

        return false;
    }
}
