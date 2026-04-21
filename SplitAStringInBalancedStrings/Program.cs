namespace SplitAStringInBalancedStrings;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "RLRRLLRLRL"); // output: 4
        Test(solution, "RLRRRLLRLL"); // output: 2
    }

    static void Test(Solution solution, string s)
    {
        var result = solution.BalancedStringSplit(s);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int BalancedStringSplit(string s)
    {
        int count = 0;
        int result = 0;

        foreach (var c in s)
        {
            if (c == 'R')
                count++;
            else
                count--;

            if (count == 0)
                result++;
        }

        return result;
    }
}