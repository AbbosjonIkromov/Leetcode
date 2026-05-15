namespace UncommonWordsFromTwoSentences;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "this apple is sweet", "this apple is sour"); // Output: ["sweet","sour"]
        Test(solution, "apple apple", "banana"); // Output: ["banana"]
    }

    static void Test(Solution solution, string s1, string s2)
    {
        var result = solution.UncommonFromSentences(s1, s2);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (string word in s1.Split(' '))
        {
            if (words.ContainsKey(word))
                words[word]++;
            else
                words[word] = 1;
        }

        foreach (string word in s2.Split(' '))
        {
            if (words.ContainsKey(word))
                words[word]++;
            else
                words[word] = 1;
        }

        List<string> result = new List<string>();

        foreach (var item in words)
        {
            if (item.Value == 1)
            {
                result.Add(item.Key);
            }
        }

        return result.ToArray();
    }
}
