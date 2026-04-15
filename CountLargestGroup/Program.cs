namespace CountLargestGroup;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, 13); // output: [4]
    }

    static void Test(Solution solution, int n)
    {
        var result = solution.CountLargestGroup(n);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CountLargestGroup(int n)
    {
        Dictionary<int, int> groupSizes = new Dictionary<int, int>();

        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            int num = i;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (groupSizes.TryGetValue(sum, out int _))
                groupSizes[sum]++;
            else
                groupSizes[sum] = 1;

        }

        int maxSize = groupSizes.Values.Max();
        
        int count = groupSizes.Values.Count(size => size == maxSize);

        return count;
    }
}