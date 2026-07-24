namespace DefuseTheBomb;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 5, 7, 1, 4 }, 3); // Output: [12, 10, 16, 13]
        Test(solution, new int[] { 1, 2, 3, 4 }, 0); // Output: [0, 0, 0, 0]
        Test(solution, new int[] { 2, 4, 9, 3 }, -2); // Output: [12, 5, 6, 13]
    }

    static void Test(Solution solution, int[] code, int k)
    {
        int[] result = solution.Decrypt(code, k);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] Decrypt(int[] code, int k)
    {
        int[] result = new int[code.Length];

        if (k == 0)
            return result;

        for (int i = 0; i < code.Length; i++)
        {
            int sum = 0;

            if (k > 0)
            {
                for (int j = 1; j <= k; j++)
                {
                    sum += code[(i + j) % code.Length];
                }
            }
            else
            {
                for (int j = 1; j <= -k; j++)
                {
                    sum += code[(i - j + code.Length) % code.Length];
                }
            }

            result[i] = sum;
        }

        return result;
    }
}
