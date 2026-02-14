namespace JewelsAndStones;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "aA", "aAAbbbb"); // Natija: 3
        Test(solution, "z", "ZZ"); // Natija: 0
    }

    static void Test(Solution solution, string jewels, string stones)
    {
        var result = solution.NumJewelsInStones(jewels, stones);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;

        foreach(char c in stones)
        {
            if (jewels.Contains(c))
                count++;
        }

        return count;
    }
}
