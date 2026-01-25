namespace BestTimeToBuyAndSellStock;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 7, 1, 5, 3, 6, 4 }); // output 5
    }

    static void Test(Solution solution, int[] prices)
    {
        var result = solution.MaxProfit(prices);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if(prices.Length == 0) return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            int currentPrice = prices[i];
            if (minPrice > currentPrice)
                minPrice = currentPrice;
            else
                maxProfit = Math.Max(maxProfit, (currentPrice - minPrice));

        }

        return maxProfit;
    }
}