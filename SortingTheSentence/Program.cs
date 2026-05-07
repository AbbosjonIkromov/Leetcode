using System.Text;

namespace SortingTheSentence;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "is2 sentence4 This1 a3"); // Output: "This is a sentence"
        Test(solution, "Myself2 Me1 I4 and3"); // Output: "Me Myself and I"
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.SortSentence(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string SortSentence(string s)
    {
        StringBuilder result = new StringBuilder();

        string[] words = s.Split(' ');
        Array.Sort(words, (a, b) => a[^1].CompareTo(b[^1]));
        for (int i = 0; i < words.Length; i++)
        {
            result.Append(words[i][..^1]);

            if (i < words.Length - 1)
            {
                result.Append(' ');
            }
        }

        return result.ToString();
    }
}