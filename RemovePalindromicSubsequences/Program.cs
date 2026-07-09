namespace RemovePalindromicSubsequences;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "ababa"); // Output: 1
        Test(solution, "abb");   // Output: 2
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.RemovePalindromeSub(s);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{   
    public int RemovePalindromeSub(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        else if (IsPalindrome(s))
        {
            return 1;
        }

        return 2;
    }

    private bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
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