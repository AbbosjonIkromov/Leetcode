namespace DistributeCandies;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 1, 2, 2, 3, 3 }); // output 
        Test(solution, new int[] { 1, 1, 2, 3 }); // output 2
        Test(solution, new int[] { 6, 6, 6, 6 }); // output 1
    }

    static void Test(Solution solution, int[] candies)
    {
        var result = solution.DistributeCandies(candies);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        int maxCandies = candyType.Length / 2;
        int uniqueTypes = candyType.Distinct().Count();

        return Math.Min(maxCandies, uniqueTypes);
    }
}



