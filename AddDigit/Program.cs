namespace AddDigit;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 38); // 2
    }

    static void Test(Solution solution, int num)
    {
        var result = solution.AddDigits(num);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int AddDigits(int num)
    {
        if (num < 10)
            return num;

        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return AddDigits(sum);
    }
}