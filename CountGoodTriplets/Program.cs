namespace CountGoodTriplets;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3); // Output: [4]
        Test(solution, new int[] { 1, 1, 2, 2, 3 }, 0, 0, 1); // Output: [0]
    }

    static void Test(Solution solution, int[] arr, int a, int b, int c)
    {
        var result = solution.CountGoodTriplets(arr, a, b, c);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a &&
                        Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}