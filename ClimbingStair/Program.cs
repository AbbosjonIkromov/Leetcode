namespace ClimbingStair;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 3); // output: 3
        Test(solution, 5); // output: 8
        Test(solution, 8); // output: 34
        Test(solution, 13); // output: 377
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.ClimbStairs(n);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int ClimbStairs(int n)
    {
        if(n <= 2) return n;

        int prev2 = 1;
        int prev1 = 2;
        for(int i = 3; i <= n; i++)
        {
            var current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}