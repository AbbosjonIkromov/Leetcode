namespace HappyNumber;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 19);   // output true
        Test(solution, 2); // output false
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.IsHappy(n);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();

        while(n != 1)
        {
            if (seen.Contains(n))
                return false;

            seen.Add(n);
            n = GetNext(n);
        }

        return true;    
    }

    private int GetNext(int n)
    {
        int sum = 0;

        while(n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}

