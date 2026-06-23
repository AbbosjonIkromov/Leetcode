namespace CountBinarySubstrings;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "00110011"); // Output: 6
        Test(solution, "10101"); // Output: 4
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.CountBinarySubstrings(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        List<int> groups = new List<int>();

        int count = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                count++;
            }
            else
            {
                groups.Add(count);
                count = 1;
            }
        }

        groups.Add(count);

        int result = 0;

        for (int i = 0; i < groups.Count - 1; i++)
        {
            result += Math.Min(groups[i], groups[i + 1]);
        }

        return result;
    }
}