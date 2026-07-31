namespace SortArrayByIncreasingFrequency;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 1, 2, 2, 2, 3 }); // Output: [3, 1, 1, 2, 2, 2]
        Test(solution, new int[] { 2, 3, 1, 3, 2 }); // Output: [1, 3, 3, 2, 2]
    }

    static void Test(Solution solution, int[] arr)
    {
        int[] result = solution.FrequencySort(arr);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        Array.Sort(nums, (a, b) =>
        {
            int freqCompare = frequencyMap[a].CompareTo(frequencyMap[b]);
            if (freqCompare == 0)
            {
                return b.CompareTo(a); // Sort in decreasing order if frequencies are the same
            }
            return freqCompare;
        });

        return nums;
    }
}
