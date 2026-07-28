namespace RelativeSortArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, new int[] { 2, 1, 4, 3, 9, 6 }); // Output: [2, 2, 2, 1, 4, 3, 3, 9, 6, 7, 19]
        Test(solution, new int[] { 28, 6, 22, 8, 44, 17 }, new int[] { 22, 28, 8, 6 }); // Output: [22, 28, 8, 6, 17, 44]
    }

    static void Test(Solution solution, int[] arr1, int[] arr2)
    {
        int[] result = solution.RelativeSortArray(arr1, arr2);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach (int num in arr1)
        {
            if (!countMap.ContainsKey(num))
                countMap[num] = 0;
            countMap[num]++;
        }
        List<int> result = new List<int>();
        foreach (int num in arr2)
        {
            if (countMap.ContainsKey(num))
            {
                for (int i = 0; i < countMap[num]; i++)
                    result.Add(num);
                countMap.Remove(num);
            }
        }
        List<int> remaining = new List<int>();
        foreach (var kvp in countMap)
        {
            for (int i = 0; i < kvp.Value; i++)
                remaining.Add(kvp.Key);
        }
        remaining.Sort();
        result.AddRange(remaining);
        return result.ToArray();
    }
}