namespace BuddyString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "ab", "ba"); // output: [True]
        Test(solution, "ab", "ab"); // output: [False]
    }

    static void Test(Solution solution, string s, string goal)
    {
        var result = solution.BuddyStrings(s, goal);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool BuddyStrings(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;

        if (s == goal)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (char c in s)
            {
                if (set.Contains(c))
                    return true;

                set.Add(c);
            }

            return false;
        }

        List<int> diff = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != goal[i])
                diff.Add(i);
        }

        if (diff.Count != 2)
            return false;

        return s[diff[0]] == goal[diff[1]] &&
               s[diff[1]] == goal[diff[0]];
    }
}