namespace LastStoneWeight;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();


        Test(solution, new int[] { 2, 7, 4, 1, 8, 1 }); // Output: 1
        Test(solution, new int[] { 5, 3, 6, 1, 2 }); // Output: 1
    }

    static void Test(Solution solution, int[] stones)
    {
        int result = solution.LastStoneWeight(stones);
        Console.WriteLine($"[{string.Join(", ", stones)}]");
    }
}

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var listOfStones = new List<int>(stones);

        while (listOfStones.Count > 1)
        {
            listOfStones.Sort();
            var x = listOfStones[^1];
            var y = listOfStones[^2];
            
            listOfStones.RemoveAt(listOfStones.Count - 1);
            listOfStones.RemoveAt(listOfStones.Count - 1);
            
            if (x != y)
            {
                listOfStones.Add(x - y);
            }
        }

        return listOfStones.Count == 0 ? 0 : listOfStones[0];
    }
}