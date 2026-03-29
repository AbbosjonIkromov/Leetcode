namespace CheckIfStringsCanBeMadeEqualsWithOperationsI;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abcd", "cdab"); // Output: [True]
        Test(solution, "abcd", "dacb"); // Output: [False]
    }

    static void Test(Solution solution, string s1, string s2)
    {
        var result = solution.CanBeEqual(s1, s2);
        Console.WriteLine($"{result}");
    }
}


public class Solution
{
    public bool CanBeEqual(string s1, string s2)
    {
        return new[] { s1[0], s1[2] }.OrderBy(x => x)
        .SequenceEqual(new[] { s2[0], s2[2] }.OrderBy(x => x))
        &&
        new[] { s1[1], s1[3] }.OrderBy(x => x)
        .SequenceEqual(new[] { s2[1], s2[3] }.OrderBy(x => x));
    }
}