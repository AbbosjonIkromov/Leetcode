namespace CountOfMatchesInTournament;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 7); // Output: 6
        Test(solution, 14); // Output: 13
    }

    static void Test(Solution solution, int n)
    {
        int result = solution.NumberOfMatches(n);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int NumberOfMatches(int n)
    {
        int matches = 0;
        while (n > 1)
        {
            if (n % 2 == 0)
            {
                matches += n / 2;
                n /= 2;
            }
            else
            {
                matches += (n - 1) / 2;
                n = (n - 1) / 2 + 1;
            }
        }
        return matches;
    }
}
