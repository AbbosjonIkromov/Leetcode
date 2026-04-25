namespace NumberOf1Bit;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 11); // output: 3
        Test(solution, 128); // output: 1
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.HammingWeight(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int HammingWeight(int n)
    {
        int count = 0;

        while (n > 0)
        {
            if (n % 2 == 1)
                count++;

            n /= 2;
        }

        return count;
    }
}