namespace TruncateSentence;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "Hello how are you Contestant", 4); // Output: "Hello how are you"
        Test(solution, "What is the solution to this problem", 4); // Output: "What is the solution"
    }

    static void Test(Solution solution, string s, int k)
    {
        string result = solution.TruncateSentence(s, k);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        string[] words = s.Split(' ');
        return string.Join(' ', words.Take(k));
    }
}