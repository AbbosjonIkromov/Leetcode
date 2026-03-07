namespace PowerOfThree;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 27); // Output: [true]
        Test(solution, 0);  // Output: [false]
        Test(solution, 9);  // Output: [true]
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.IsPowerOfThree(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0) return false;

        while (n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }
}