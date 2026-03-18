namespace ReverseStringII;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abcdefg", 2); // Output: [bacdfeg]
        Test(solution, "abcd", 2); // Output: [bacd]
    }

    static void Test(Solution solution, string s, int k)
    {
        var result = solution.ReverseStr(s, k);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] arr = s.ToCharArray();
        int length = arr.Length;

        for (int i = 0; i < length; i += 2 * k)
        {
            int left = i;
            int right = Math.Min(i + k - 1, length - 1);

            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        return new string(arr);
    }
}
