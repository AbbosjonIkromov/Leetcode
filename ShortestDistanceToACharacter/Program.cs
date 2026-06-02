namespace ShortestDistanceToACharacter;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "loveleetcode", 'e'); // Output: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
        Test(solution, "aaab", 'b'); // Output: [3, 2, 1, 0]
    }

    static void Test(Solution solution, string s, char c)
    {
        var result = solution.ShortestToChar(s, c);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] result = new int[n];
        int prev = -n; 

        for (int i = 0; i < n; i++)
        {
            if (s[i] == c)
            {
                prev = i;
            }
            result[i] = i - prev;
        }
        prev = 2 * n; 

        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == c)
            {
                prev = i;
            }
            result[i] = Math.Min(result[i], prev - i);
        }
        return result;
    }
}
