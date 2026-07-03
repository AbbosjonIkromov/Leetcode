namespace DuplicateZeros;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };

        solution.DuplicateZeros(arr);
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }
}

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }

                if (i + 1 < arr.Length)
                {
                    arr[i + 1] = 0;
                }

                i++;
            }
        }
    }
}
