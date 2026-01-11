namespace MergeSortedArray;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3); // output [1,2,2,3,5,6]
        Test(solution, new int[] { 1 }, 1, new int[] { }, 0); // output [1]
    }

    static void Test(Solution solution, int[] nums1, int m, int[] nums2, int n)
    {
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine("[" + string.Join(", ", nums1) + "]");
    }
}


public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1; // Pointer for nums1
        int j = n - 1; // Pointer for nums2
        int k = m + n - 1; // Pointer for merged array

        while(j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}