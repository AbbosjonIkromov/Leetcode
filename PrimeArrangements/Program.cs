namespace PrimeArrangements;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, 5); // output: 12
        Test(solution, 100); // output: 682289015
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.NumPrimeArrangements(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    private const int Mod = 1000000007;
    public int NumPrimeArrangements(int n)
    {
        int count = 0;
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                count++;
            }
        }
        long primeFactorial = Factorial(count);
        long nonPrimeFactorial = Factorial(n - count);
        long result = (primeFactorial * nonPrimeFactorial) % Mod;
        return (int)result;
    }
    public int Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result = (result * i) % Mod;
        }
        return (int)result;
    }

    public bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}