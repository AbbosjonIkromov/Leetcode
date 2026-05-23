namespace PerfectNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 28); // output: [True]
        Test(solution, 7); // output: [False]
    }

    static void Test(Solution solution, int num)
    {
        var result = solution.CheckPerfectNumber(num);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num == 1)
            return false;

        int sum = 1;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                sum += i;

                if (i != num / i)
                {
                    sum += num / i;
                }
            }
        }

        return sum == num;
    }
}