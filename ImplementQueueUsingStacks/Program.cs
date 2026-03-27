namespace ImplementQueueUsingStacks;

internal class Program
{
    static void Main(string[] args)
    {
        MyQueue queue = new MyQueue();

        queue.Push(1);
        queue.Push(2);
        queue.Push(3);

        Console.WriteLine(queue.Peek()); // output: 1
        Console.WriteLine(queue.Pop()); // output: 1
        Console.WriteLine(queue.Empty()); // output: false
    }
}


public class MyQueue
{
    private Stack<int> stack1;
    private Stack<int> stack2;

    public MyQueue()
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    public void Push(int x)
    { 
        stack1.Push(x);
    }

    public int Pop()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Pop();
    }

    public int Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Peek();
    }

    public bool Empty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}
