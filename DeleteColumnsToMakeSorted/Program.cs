namespace DeleteColumnsToMakeSorted;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "abc", "bcd", "cde" }); // output: 0
        Test(solution, new string[] { "cba", "daf", "ghi" }); // output: 1
    }

    static void Test(Solution solution, string[] strs)
    {
        var result = solution.MinDeletionSize(strs);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int count = 0;
        int rows = strs.Length;
        int cols = strs[0].Length;

        for (int j = 0; j < cols; j++)
        {
            for (int i = 1; i < rows; i++)
            {
                if (strs[i][j] < strs[i - 1][j])
                {
                    count++;
                    break;
                }
            }
        }

        return count;
    }
}