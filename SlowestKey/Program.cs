namespace SlowestKey;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 9, 29, 49, 50 }, "cbcd"); // Output: [c]
        Test(solution, new int[] { 12, 23, 36, 46, 62 }, "spuda"); // Output: [a]
    }

    static void Test(Solution solution, int[] releaseTimes, string keysPressed)
    {
        char result = solution.SlowestKey(releaseTimes, keysPressed);
        Console.WriteLine($"[{result}]");
    }
}

public class Solution
{
    public char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        int maxDuration = releaseTimes[0];
        char slowestKey = keysPressed[0];

        for (int i = 1; i < releaseTimes.Length; i++)
        {
            int duration = releaseTimes[i] - releaseTimes[i - 1];

            if (duration > maxDuration ||
                (duration == maxDuration && keysPressed[i] > slowestKey))
            {
                maxDuration = duration;
                slowestKey = keysPressed[i];
            }
        }

        return slowestKey;
    }
}