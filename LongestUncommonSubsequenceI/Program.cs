namespace LongestUncommonSubsequenceI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Test(solution, "aba", "cdc"); // output 3
            Test(solution, "aaa", "aaa"); // output -1
        }

        static void Test(Solution solution, string str1, string str2)
        {
            var result = solution.FindLUSlength(str1, str2);
            Console.WriteLine($"[{result}]");
        }
    }
}


public class Solution
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b) return -1;
        return Math.Max(a.Length, b.Length);
    }
}