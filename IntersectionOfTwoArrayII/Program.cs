namespace IntersectionOfTwoArrayII;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }); // output [2, 2]
        Test(solution, new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }); // output [4, 9]
    }

    static void Test(Solution solution, int[] nums1, int[] nums2)
    {
        var result = solution.Intersect(nums1, nums2);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in nums1)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        List<int> result = new List<int>();
        foreach (int num in nums2)
        {
            if (counts.ContainsKey(num) && counts[num] > 0)
            {
                result.Add(num);
                counts[num]--;
            }
        }
        return result.ToArray();
    }
}