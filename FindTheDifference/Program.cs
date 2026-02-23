namespace FindTheDifference;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abcd", "abcde"); // e
        Test(solution, "", "y"); // y
    }

    static void Test(Solution solution, string s, string t)
    {
        var result = solution.FindTheDifference(s, t);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int sumS = 0, sumT = 0;
        foreach (char c in s) sumS += c;
        foreach (char c in t) sumT += c;
        return (char)(sumT - sumS);
    }
}
