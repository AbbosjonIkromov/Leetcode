namespace UglyNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 6); // output true
        Test(solution, 8); // output true
        Test(solution, 14); // output false
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.IsUgly(n);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool IsUgly(int n)
    {
        if(n <= 0) return false;

        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n == 1;
    }
}
