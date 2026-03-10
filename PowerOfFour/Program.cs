namespace PowerOfFour;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 16); // Output: [true]
        Test(solution, 5);  // Output: [false]
        Test(solution, 1);  // Output: [true]
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.IsPowerOfFour(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0) return false;

        while (n % 4 == 0)
        {
            n /= 4;
        }

        return n == 1;
    }
}