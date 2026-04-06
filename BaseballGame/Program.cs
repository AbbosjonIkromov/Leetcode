namespace BaseballGame;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new string[] { "5", "2", "C", "D", "+" }); // output: 30
    }

    static void Test(Solution solution, string[] operations)
    {
        int result = solution.CalPoints(operations);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public int CalPoints(string[] operations)
    {
        Stack<int> result = new Stack<int>();
        foreach (string operation in operations)
        {
            if(operation == "C")
            {
                result.Pop();
            }
            else if(operation == "D")
            {
                result.Push(result.Peek() * 2);
            }
            else if(operation == "+")
            {
                int first = result.Pop();
                int second = result.Peek();

                result.Push(first);
                result.Push(first + second);
            }
            else
            {
                result.Push(int.Parse(operation));
            }
        }

        return result.Sum();
    }
}