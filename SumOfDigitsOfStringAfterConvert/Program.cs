using System.Text;

namespace SumOfDigitsOfStringAfterConvert;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "iiii", 1); // Output: 36
        Test(solution, "leetcode", 2); // Output: 6
    }

    static void Test(Solution solution, string s, int k)
    {
        var result = solution.GetLucky(s, k);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int GetLucky(string s, int k)
    {
        StringBuilder numbers = new StringBuilder();

        foreach (char c in s)
        {
            int digit = c - 'a' + 1;
            numbers.Append(digit);
        }

        string current = numbers.ToString();

        for (int i = 0; i < k; i++)
        {
            int sum = 0;
            foreach (char digit in current)
            {
                sum += digit - '0';
            }
            current = sum.ToString();
        }

        return int.Parse(current);
    }
}