namespace WordPattern;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abba", "dog cat cat dog"); // output: true
        Test(solution, "abba", "dog cat cat fish"); // output: false
    }

    private static void Test(Solution solution, string pattern, string s)
    {
        var result = solution.WordPattern(pattern, s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (pattern.Length != words.Length)
            return false;

        Dictionary<char, string> dict = new Dictionary<char, string>();
        Dictionary<string, char> dict2 = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word = words[i];
            if (dict.TryGetValue(c, out var existingWord))
            {
                if (existingWord != word)
                    return false;
            }
            else
            {
                dict[c] = word;
            }

            if (dict2.TryGetValue(word, out var existingChar))
            {
                if (existingChar != c)
                    return false;
            }
            else
            {
                dict2[word] = c;
            }
        }

        return true;
    }
}