namespace LongestNiceSubString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "YazaAay"); // Output: "aAa"
        Test(solution, "Bb"); // Output: "Bb"
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.LongestNiceSubstring(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string LongestNiceSubstring(string s)
    {
        string result = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string sub = s.Substring(i, j - i);

                if (IsNice(sub) && sub.Length > result.Length)
                {
                    result = sub;
                }
            }
        }

        return result;
    }

    private bool IsNice(string s)
    {
        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                if (!s.Contains(char.ToUpper(c)))
                    return false;
            }
            else
            {
                if (!s.Contains(char.ToLower(c)))
                    return false;
            }
        }

        return true;
    }
}