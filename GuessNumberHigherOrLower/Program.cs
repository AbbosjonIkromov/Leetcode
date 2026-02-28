namespace GuessNumberHigherOrLower;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int pick = 6;

        Solution solution = new Solution(pick);
        int result = solution.GuessNumber(n);

        Console.WriteLine($"Pick: {pick}, Guess: {result}");
    }
}



public class Solution : GuessGame
{
    public Solution(int pick) : base(pick)
    {
    }

    public int GuessNumber(int n)
    {
        int left = 1;
        int right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            int result = guess(mid);

            if (result == 0)
                return mid;
            else if (result < 0)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
}


#region GuessGame (API simulyatsiyasi)
public class GuessGame
{
    protected int pick;

    public GuessGame(int pick)
    {
        this.pick = pick;
    }

    protected int guess(int num)
    {
        if (num > pick) return -1;
        if (num < pick) return 1;
        return 0;
    }
}
#endregion