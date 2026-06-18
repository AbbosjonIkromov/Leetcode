namespace AvailableCapturesForRook;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new char[][]
        {
            new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', 'R', '.', '.', '.', 'p'},
            new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
            new char[] {'.', '.', '.', 'p', '.', '.', '.', '.'}
        }); // Output: [3]
    }

    static void Test(Solution solution, char[][] board)
    {
        var result = solution.NumRookCaptures(board);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int NumRookCaptures(char[][] board)
    {
        int rookRow = 0;
        int rookCol = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (board[i][j] == 'R')
                {
                    rookRow = i;
                    rookCol = j;
                    break;
                }
            }
        }

        int count = 0;

        for (int i = rookRow - 1; i >= 0; i--)
        {
            if (board[i][rookCol] == 'B')
                break;

            if (board[i][rookCol] == 'p')
            {
                count++;
                break;
            }
        }

        for (int i = rookRow + 1; i < 8; i++)
        {
            if (board[i][rookCol] == 'B')
                break;

            if (board[i][rookCol] == 'p')
            {
                count++;
                break;
            }
        }

        for (int j = rookCol - 1; j >= 0; j--)
        {
            if (board[rookRow][j] == 'B')
                break;

            if (board[rookRow][j] == 'p')
            {
                count++;
                break;
            }
        }

        for (int j = rookCol + 1; j < 8; j++)
        {
            if (board[rookRow][j] == 'B')
                break;

            if (board[rookRow][j] == 'p')
            {
                count++;
                break;
            }
        }

        return count;
    }
}