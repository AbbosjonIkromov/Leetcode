namespace AssignCookies;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3 }, new int[] { 1, 1 }); // Output: 1
        Test(solution, new int[] { 1, 2 }, new int[] { 1, 2, 3 }); // Output: 2
    }

    static void Test(Solution solution, int[] g, int[] s)
    {
        var result = solution.FindContentChildren(g, s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int child = 0, cookie = 0;

        while (child < g.Length && cookie < s.Length)
        {
            if (s[cookie] >= g[child])
            {
                child++;
            }
            cookie++;
        }

        return child;
    }
}