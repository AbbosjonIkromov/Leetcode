namespace SquaresOfASortedArray;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { -4, -1, 0, 3, 10 }); // Natija: [0,1,9,16,100]
        Test(solution, new int[] { -7, -3, 2, 3, 11 }); // Natija: [4,9,9,49,121]
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.SortedSquares(nums);
        Console.WriteLine($"[{string.Join(',', result)}]");
    }
}


public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        int left = 0;
        int right = n - 1;
        int pos = n - 1;

        while (left <= right)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[pos] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[pos] = nums[right] * nums[right];
                right--;
            }

            pos--;
        }

        return result;
    }
}