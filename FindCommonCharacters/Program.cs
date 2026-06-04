namespace FindCommonCharacters;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "bella", "label", "roller" }); // Output: ["e", "l", "l"]
        Test(solution, new string[] { "cool", "lock", "cook" }); // Output: ["c", "o"]
    }

    static void Test(Solution solution, string[] words)
    {
        var result = solution.CommonChars(words);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        int[] common = new int[26];

        for (int i = 0; i < 26; i++)
            common[i] = int.MaxValue;

        foreach (string word in words)
        {
            int[] count = new int[26];

            foreach (char c in word)
                count[c - 'a']++;

            for (int i = 0; i < 26; i++)
                common[i] = Math.Min(common[i], count[i]);
        }

        List<string> result = new List<string>();

        for (int i = 0; i < 26; i++)
        {
            while (common[i] > 0)
            {
                result.Add(((char)(i + 'a')).ToString());
                common[i]--;
            }
        }

        return result;
    }
}