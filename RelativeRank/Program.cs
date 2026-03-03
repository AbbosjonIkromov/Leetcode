namespace RelativeRank;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 10, 3, 8, 9, 4 }); // ["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"]
        Test(solution, new int[] { 5, 4, 3, 2, 1 }); // ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
    }

    static void Test(Solution solution, int[] score)
    {
        var result = solution.FindRelativeRanks(score);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        int scoreLength = score.Length;
        string[] result = new string[scoreLength];

        int[] scoreClone = (int[])score.Clone();
        Array.Sort(scoreClone, (a, b) => b.CompareTo(a)); // Sort in descending order

        for (int i = 0; i < scoreLength; i++)
        {
            int position = Array.IndexOf(scoreClone, score[i]);

            if (position == 0)
                result[i] = "Gold Medal";
            else if (position == 1)
                result[i] = "Silver Medal";
            else if (position == 2)
                result[i] = "Bronze Medal";
            else
                result[i] = (position + 1).ToString();
        }

        return result;
    }
}