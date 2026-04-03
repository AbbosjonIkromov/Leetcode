namespace ShortestCompletingWord;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "1s3 PSt", new string[] { "step", "steps", "stripe", "stepple" }); // output: "steps"
    }

    static void Test(Solution solution, string licensePlate, string[] words)
    {
        string result = solution.ShortestCompletingWord(licensePlate, words);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        Dictionary<char, int> licensePlatedict = GetCharFrequency(licensePlate);

        string shortestWord = string.Empty;

        foreach (string word in words)
        {
            var wordFrequency = GetCharFrequency(word);

            bool isValid = true;
            foreach (var kvp in licensePlatedict)
            {
                if (!wordFrequency.TryGetValue(kvp.Key, out int count) || count < kvp.Value)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                if (shortestWord == string.Empty || word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
        }

        return shortestWord;
    }

    private Dictionary<char, int> GetCharFrequency(string word)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in word)
        {
            if (!char.IsLetter(c)) continue;

            char lowerChar = char.ToLower(c);

            if (frequency.TryGetValue(lowerChar, out _))
            {
                frequency[lowerChar]++;
            }
            else
            {
                frequency[lowerChar] = 1;
            }
        }

        return frequency;
    }
}