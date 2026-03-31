namespace LongestPalindrome;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abccccdd"); // output: 7
        Test(solution, "cdcdcdc"); // output: 5
    }

    static void Test(Solution solution, string s)
    {
        int result = solution.LongestPalindrome(s);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dict.TryGetValue(c, out _))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        int length = 0;
        bool hasOdd = false;

        foreach (var kv in dict)
        {
            int count = kv.Value;

            length += (count / 2) * 2;

            if (count % 2 == 1)
            {
                hasOdd = true;
            }
        }

        if (hasOdd)
        {
            length++;
        }

        return length;
    }
}