namespace CountVowelSubstringsOfAString;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, "aeiouu"); // output: 2
        Test(solution, "unicornarihan"); // output: 0
    }

    static void Test(Solution solution, string word)
    {
        var result = solution.CountVowelSubstrings(word);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CountVowelSubstrings(string word)
    {
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            HashSet<char> vowels = new HashSet<char>();

            for (int j = i; j < word.Length; j++)
            {
                if (!IsVowel(word[j]))
                {
                    break;
                }
                vowels.Add(word[j]);
                if (vowels.Count == 5)
                {
                    count++;
                }
            }
        }

        return count;
    }

    private bool IsVowel(char c)
    {
        return c == 'a' 
            || c == 'e' 
            || c == 'i' 
            || c == 'o' 
            || c == 'u';
    }
}