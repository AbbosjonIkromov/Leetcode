namespace MakeTheStringGreat;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "leEeetcode"); // Output: "leetcode"
        Test(solution, "abBAcC"); // Output: ""
    }

    static void Test(Solution solution,  string s)
    {
        var result = solution.MakeGood(s);
        Console.WriteLine($"[{result}]");
    }
}   



public class Solution
{
    public string MakeGood(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (Math.Abs(s[i] - s[i + 1]) == 32)
            {
                s = s.Remove(i, 2);
                i = -1;
            }
        }

        return s;
    }
}