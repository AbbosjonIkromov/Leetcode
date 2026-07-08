namespace FindNumbersWithEvenNumberOfDigits;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 12, 345, 2, 6, 7896 }); // Output: 2
        Test(solution, new int[] { 555, 901, 482, 1771 }); // Output: 1
    }

    static void Test(Solution solution, int[] nums)
    {
        var result = solution.FindNumbers(nums);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        var countOfEvenDigitNumbers = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var numberOfDigits = nums[i].ToString().Length;
            if (numberOfDigits % 2 == 0)
            {
                countOfEvenDigitNumbers++;
            }
        }
        
        return countOfEvenDigitNumbers;
    }
}
