namespace PlusOne;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();

        Test(solution, new int[] { 1, 2, 3 }); // [1, 2, 4]
        Test(solution, new int[] { 4, 3, 2, 1 }); // [4, 3, 2, 2]
        Test(solution, new int[] { 9, 9, 9 }); // [1, 0]

    }

    static void Test(Solution solution, int[] digits)
    {
        var result = solution.PlusOne(digits);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}


public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var lenght = digits.Length;

        for (int i = lenght - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }

        var result = new int[lenght + 1];
        result[0] = 1;
        return result;
    }
}
