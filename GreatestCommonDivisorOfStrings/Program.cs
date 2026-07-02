namespace GreatestCommonDivisorOfStrings;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "ABCABC", "ABC"); // output: "ABC"
        Test(solution, "ABABAB", "ABAB"); // output: "AB"
    }

    static void Test(Solution solution, string str1, string str2)
    {
        var result = solution.GcdOfStrings(str1, str2);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return "";

        var gcdLength = GCD(str1.Length, str2.Length);

        return str1.Substring(0, gcdLength);
    }

    private int GCD(int str1Length, int str2Length)
    {
        if (str2Length == 0)
            return str1Length;

        return GCD(str2Length, str1Length % str2Length);
    }
}