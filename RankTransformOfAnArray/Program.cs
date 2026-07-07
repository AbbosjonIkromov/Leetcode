namespace RankTransformOfAnArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 40, 10, 20, 30 }); // Output: [4, 1, 2, 3]
        Test(solution, new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 }); // Output: [5, 3, 4, 2, 8, 6, 7, 1, 3]
    }

    static void Test(Solution solution, int[] arr)
    {
        var result = solution.ArrayRankTransForm(arr);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] ArrayRankTransform(int[] arr)
    {
        Dictionary<int, int> rankMap = new Dictionary<int, int>();

        int[] sortedArray = arr.Distinct().ToArray();
        Array.Sort(sortedArray);

        for (int i = 0; i < sortedArray.Length; i++)
        {
            rankMap[sortedArray[i]] = i + 1;
        }

        int[] result = new int[arr.Length];

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = rankMap[arr[i]];
        }

        return result;
    }
}