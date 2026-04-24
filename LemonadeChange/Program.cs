namespace LemonadeChange;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new int[] { 5, 5, 5, 10, 20 }); // output: True
    }

    static void Test(Solution solution, int[] bills)
    {
        var result = solution.LemonadeChange(bills);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int five = 0;
        int ten = 0;

        foreach (var bill in bills)
        {
            if (bill == 5)
            {
                five++;
            }
            else if (bill == 10)
            {
                if (five == 0)
                    return false;

                five--;
                ten++;
            }
            else
            {
                if (ten > 0 && five > 0)
                {
                    ten--;
                    five--;
                }
                else if (five >= 3)
                {
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}