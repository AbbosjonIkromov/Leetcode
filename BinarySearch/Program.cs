namespace BinarySearch;

internal class Program
{
    static void Main(string[] args)
    {
        Solutin solutin = new Solutin();

        Test(solutin, new int[] { -1, 0, 3, 5, 9, 12 }, 9); // Output: 4
        Test(solutin, new int[] { -1, 0, 3, 5, 9, 12 }, 2); // Output: -1
    }

    static void Test(Solutin solutin, int[] nums, int target)
    {
        var result = solutin.Search(nums, target);
        Console.WriteLine($"[{result}]");
    }
}


public class Solutin
{
    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}
