namespace RotateString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abcde", "cdeab"); // Output: [True]
        Test(solution, "abcde", "abced"); // Output: [False]
    }

    static void Test(Solution solution, string s1, string s2)
    {
        var result = solution.RotateString(s1, s2);
        Console.WriteLine($"{result}");
    }
}


public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;
        return (s + s).Contains(goal);
    }
}