namespace DistibuteCandiesToPeople;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 7, 4); // Output: [1, 2, 3, 1]
        Test(solution, 10, 3); // Output: [5, 2, 3]
    }

    static void Test(Solution solution, int candies, int num_people)
    {
        var result = solution.DistributeCandies(candies, num_people);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] DistributeCandies(int candies, int num_people)
    {
        int[] distribution = new int[num_people];

        int give = 1;
        int index = 0;

        while (candies > 0)
        {
            distribution[index] += Math.Min(give, candies);
            candies -= give;
            give++;
            index = (index + 1) % num_people;
        }

        return distribution;
    }
}