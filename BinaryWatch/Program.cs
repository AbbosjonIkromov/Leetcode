namespace BinaryWatch;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        Test(solution, 1); // ["0:01","0:02","0:04","0:08","0:16","0:32","1:00","2:00","4:00","8:00"]
        Test(solution, 9); // []
    }

    static void Test(Solution solution, int turnedOn)
    {
        var result = solution.ReadBinaryWatch(turnedOn);
        Console.WriteLine($"[{string.Join(',', result)}]");
    }
}

public class Solution
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var result = new List<string>();

        for (int h = 0; h < 12; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                if(CountBits(h) + CountBits(m) == turnedOn)
                    result.Add($"{h}:{m:D2}");
            }
        }
        
        return result;
    }

    private int CountBits(int n)
    {
        int count = 0;

        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}