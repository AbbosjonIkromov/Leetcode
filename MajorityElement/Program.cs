namespace MajorityElement;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 3, 2, 3 });   // output 3

        Test(solution, new int[] { 2, 2, 1, 1, 1, 2, 2 }); // output 2

        Test(solution, new int[] { 1 }); // output 1
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.MajorityElement(nums);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            if (num == candidate)
                count++;
            else
                count--;
        }

        return candidate;
    }
}