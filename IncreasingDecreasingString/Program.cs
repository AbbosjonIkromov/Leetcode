using System.Text;

namespace IncreasingDecreasingString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "aaaabbbbcccc"); // Output: "abccbaabccba"
        Test(solution, "rat"); // Output : "art"
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.SortString(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string SortString(string s)
    {
        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }

        StringBuilder result = new StringBuilder();
        while (result.Length < s.Length)
        {
            for (int i = 0; i < 26; i++)
            {
                if (count[i] > 0)
                {
                    result.Append((char)(i + 'a'));
                    count[i]--;
                }
            }
            for (int i = 25; i >= 0; i--)
            {
                if (count[i] > 0)
                {
                    result.Append((char)(i + 'a'));
                    count[i]--;
                }
            }
        }

        return result.ToString();
    }
}