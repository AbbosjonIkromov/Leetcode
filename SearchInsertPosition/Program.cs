namespace SearchInsertPosition;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, new int[] { 1, 3, 5, 6 }, 5); // Output: 2
        Test(solution, new int[] { 1, 3, 5, 6 }, 2); // Output: 1
    }

    static void Test(Solution solution, int[] nums, int target)
    {
        var result = solution.SearchInsert(nums, target);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int mid = 0;
        while(left <= right)
        {
            mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }
}
