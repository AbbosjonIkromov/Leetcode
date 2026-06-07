namespace DivisorGame;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 2); // output: true
        Test(solution, 3); // output: false
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.DivisorGame(n);
        Console.WriteLine($"{result}");
    }
}


public class Solution
{
    public bool DivisorGame(int n)
    {
        return n % 2 == 0;
    }
}