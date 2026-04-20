namespace ReversePrefixOfWord;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "abcdefd", 'd'); // output: dcbaefd
        Test(solution, "xyxzxe", 'z'); // output: zxyxxe
    }

    static void Test(Solution solution, string word, char ch)
    {
        var result = solution.ReversePrefix(word, ch);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int index = word.IndexOf(ch);

        if (index == -1)
            return word;

        char[] arr = word.ToCharArray();

        int left = 0, right = index;

        while (left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }

        return new string(arr);
    }
}