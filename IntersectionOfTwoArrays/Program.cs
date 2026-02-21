namespace IntersectionOfTwoArrays;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 2, 1 }, new int[] { 2 }); // [2]
        Test(solution, new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }); // [9, 4]
    }

    static void Test(Solution solution, int[] nums1, int[] nums2)
    {
        var ressult = solution.Intersection(nums1, nums2);
        Console.WriteLine($"[{string.Join(", ", ressult)}]");
    }
}


public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set = new HashSet<int>(nums1);
        HashSet<int> resultSet = new HashSet<int>();

        foreach (int num in nums2)
        {
            if (set.Contains(num))
            {
                resultSet.Add(num);
            }
        }

        return resultSet.ToArray();
    }
}