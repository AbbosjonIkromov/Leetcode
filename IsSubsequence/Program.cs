namespace IsSubsequence;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abc", "ahbgdc"); // true
        Test(solution, "axc", "ahbgdc"); // false
    }

    static void Test(Solution solution, string s, string t)
    {
        var result = solution.IsSubsequence(s, t);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int index = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int foundIndex = t.IndexOf(s[i], index);

            if (foundIndex == -1)
                return false;

            index = foundIndex + 1;
        }

        return true;
    }
}
