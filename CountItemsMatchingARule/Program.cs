namespace CountItemsMatchingARule;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Test(solution, new List<IList<string>>
        {
            new List<string> { "phone", "blue", "pixel" },
            new List<string> { "computer", "silver", "lenovo" },
            new List<string> { "phone", "gold", "iphone" }
        }, "color", "silver", 1); // Output: 1
    }

    static void Test(Solution solution, IList<IList<string>> items, string ruleKey, string ruleValue, int expected)
    {
        var result = solution.CountMatches(items, ruleKey, ruleValue);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int countMatches = 0;
        int ruleKeyIndex = ruleKey switch
        {
            "type" => 0,
            "color" => 1,
            "name" => 2,
            _ => throw new ArgumentException("Invalid rule key")
        };

        foreach (var item in items)
        {
            if (item[ruleKeyIndex] == ruleValue)
            {
                countMatches++;
            }
        }

        return countMatches;
    }
}
