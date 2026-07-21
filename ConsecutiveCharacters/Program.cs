namespace ConsecutiveCharacters;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, "leetcode"); // Output: 2
        Test(solution, "abbcccddddeeeeedcba"); // Output: 5
    }

    static void Test(Solution solution, string s)
    {
        int result = solution.MaxPower(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MaxPower(string s)
    {
        int maxPower = 1;
        int currentPower = 1;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                currentPower++;
                maxPower = Math.Max(maxPower, currentPower);
            }
            else
            {
                currentPower = 1;
            }
        }

        return maxPower;
    }
}