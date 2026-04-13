namespace StringMatchingInAArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "mass", "as", "hero", "superhero" }); // output: ["as", "hero"]
        Test(solution, new string[] { "leetcode", "et", "code" }); // output: ["et", "code"]
    }

    static void Test(Solution solution, string[] words)
    {
        var result = solution.StringMatching(words);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        List<string> result = new List<string>();
        for (int  i = 0; i < words.Length; i++)
        {
            if (IsSubString(words, words[i]))
                result.Add(words[i]);
        }

        return result;
    }

    public bool IsSubString(string[] words, string str)
    {
        return words.Any(w => w != str && w.Contains(str));
    }
}