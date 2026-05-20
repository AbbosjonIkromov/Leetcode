namespace FibonacciNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 2); // Output: 1
        Test(solution, 3); // Output: 2
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.Fib(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int Fib(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}