namespace CrawlerLogFolder;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "d1/", "d2/", "../", "d21/", "./" }); // Output: 2
        Test(solution, new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }); // Output: 3
    }

    static void Test(Solution solution, string[] logs)
    {
        var result = solution.MinOperations(logs);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MinOperations(string[] logs)
    {
        int depth = 0;
        foreach (string log in logs)
        {
            if (log == "../")
            {
                if (depth > 0)
                {
                    depth--;
                }
            }
            else if (log != "./")
            {
                depth++;
            }
        }

        return depth;
    }
}