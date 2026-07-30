namespace CheckIfNAndItsDoubleExit;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 10, 2, 5, 3 }); //  output: [true]
        Test(solution, new int[] { 7, 1, 14, 11 }); // output: [true]
    }

    static void Test(Solution solution, int[] arr)
    {
        bool result = solution.CheckIfExist(arr);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in arr)
        {
            bool isDoubleExist = seen.Contains(num * 2);
            bool isHalfExist = (num % 2 == 0) && seen.Contains(num / 2);
            if (isDoubleExist || isHalfExist)
            {
                return true;
            }
            else
            {
                seen.Add(num);
            }
        }

        return false;
    }
}