namespace SortArrayByParity;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 3, 1, 2, 4 }); // output: [2, 4, 3, 1]

    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.SortArrayByParity(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int[] result = new int[nums.Length];
        int evenIndex = 0;
        int oddIndex = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[evenIndex] = nums[i];
                evenIndex++;
            }
            else
            {
                result[oddIndex] = nums[i];
                oddIndex--;
            }
        }

        return result;
    }
}