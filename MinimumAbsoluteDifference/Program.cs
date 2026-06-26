namespace MinimumAbsoluteDifference;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 4, 2, 1, 3 }); // Output: [[1, 2], [2, 3], [3, 4]]
        Test(solution, new int[] { 1, 3, 6, 10, 15 }); // Output: [[1, 3]]
    }

    static void Test(Solution solution, int[] arr)
    {
        var result = solution.MinimumAbsDifference(arr);
        Console.WriteLine($"[{string.Join(", ", result.Select(pair => $"[{string.Join(", ", pair)}]"))}]");
    }
}

public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        int minDiff = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            minDiff = Math.Min(minDiff, arr[i] - arr[i - 1]);
        }

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] == minDiff)
            {
                result.Add(new List<int>
                {
                    arr[i - 1],
                    arr[i]
                });
            }
        }

        return result;
    }
}