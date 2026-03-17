namespace NimGame;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 1); // Output: [True]
        Test(solution, 2); // Output: [True]
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.CanWinNim(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool CanWinNim(int n)
    {
        return n % 4 != 0;
    }
}