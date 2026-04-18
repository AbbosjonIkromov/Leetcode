namespace OccurrencesAfterBigram;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "we will we will rock you", "we", "will"); // output: ["we", "rock"]
    }

    static void Test(Solution solution, string text, string first, string second)
    {
        var result = solution.FindOcurrences(text, first, second);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}



public class Solution
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var words = text.Split(' ');
        var result = new List<string>();

        for (int i = 0; i < words.Length - 2; i++)
        {
            if (words[i] == first && words[i + 1] == second)
            {
                result.Add(words[i + 2]);
            }
        }

        return result.ToArray();
    }
}