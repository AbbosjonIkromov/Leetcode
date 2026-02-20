namespace ValidPalindromII;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "aba"); // true
        Test(solution, "abca"); // true
        Test(solution, "abc"); // falseS
    }

    static void Test(Solution solution, string s)
    {
        var ressult = solution.ValidPalindrome(s);
        Console.WriteLine($"[{ressult}]");
    }
}
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
            }
            left++;
            right--;
        }
        return true;
    }
    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
