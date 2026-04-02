namespace DIStringMatch;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


public class Solution
{
    public int[] DiStringMatch(string s)
    {
        int length = s.Length;
        int[] result = new int[length + 1];
        
        for (int i = 0, low = 0, high = length; i <= length; i++)
        {
            if (i == length || s[i] == 'I')
            {
                result[i] = low++;
            }
            else
            {
                result[i] = high--;
            }
        }
        return result;
    }
}