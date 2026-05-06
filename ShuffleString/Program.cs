namespace ShuffleString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }); // Output: "leetcode
    }

    static void Test(Solution solution, string s, int[] indices)
    {
        var result = solution.RestoreString(s, indices);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        int length = s.Length;
        char[] result = new char[length];

        for (int i = 0; i < length; i++)
        {
            result[indices[i]] = s[i];
        }

        return new string(result);
    }
}