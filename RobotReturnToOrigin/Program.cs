namespace RobotReturnToOrigin;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, "UD"); // output true
        Test(solution, "LL"); // output false
    }

    static void Test(Solution solution, string moves)
    {
        var result = solution.JudgeCircle(moves);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;
        foreach (char move in moves)
        {
            switch (move)
            {
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'L':
                    x--;
                    break;
                case 'R':
                    x++;
                    break;
            }
        }
        return x == 0 && y == 0;
    }
}