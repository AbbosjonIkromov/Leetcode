namespace RingsandRods;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "B0B6G0R6R0R6G9"); // Expected output: [1]
        Test(solution, "B0R0G0R9R0B0G0"); // Expected output: [1]
    }

    static void Test(Solution solution, string rings)
    {
        int result = solution.CountPoints(rings);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public int CountPoints(string rings)
    {
        bool[,] rods = new bool[10, 3]; // 10 rods, 3 colors (R, G, B)

        for (int i = 0; i < rings.Length; i += 2)
        {
            char color = rings[i];
            int rodIndex = rings[i + 1] - '0';
            switch (color)
            {
                case 'R':
                    rods[rodIndex, 0] = true;
                    break;
                case 'G':
                    rods[rodIndex, 1] = true;
                    break;
                case 'B':
                    rods[rodIndex, 2] = true;
                    break;
            }
        }

        int result = 0;

        for (int i = 0; i < 10; i++)
        {
            if (rods[i, 0] && rods[i, 1] && rods[i, 2])
            {
                result++;
            }
        }

        return result;
    }
}
