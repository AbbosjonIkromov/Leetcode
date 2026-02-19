namespace ImplementStackUsingQueues;

internal class Program
{
    static void Main(string[] args)
    {
        MyStack myStack = new MyStack();

        myStack.Push(1);
        myStack.Push(2);

        Console.WriteLine(myStack.Top());   // 2
        Console.WriteLine(myStack.Pop());   // 2
        Console.WriteLine(myStack.Empty()); // False
    }
}


public class MyStack
{
    private Queue<int> queue1;
    private Queue<int> queue2;
    public MyStack()
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }
    public void Push(int x)
    {
        queue1.Enqueue(x);
    }
    public int Pop()
    {
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }
        int topElement = queue1.Dequeue();
        SwapQueues();
        return topElement;
    }
    public int Top()
    {
        while (queue1.Count > 1)
        {
            queue2.Enqueue(queue1.Dequeue());
        }
        int topElement = queue1.Dequeue();
        queue2.Enqueue(topElement);
        SwapQueues();
        return topElement;
    }
    public bool Empty()
    {
        return queue1.Count == 0 && queue2.Count == 0;
    }
    private void SwapQueues()
    {
        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }
}
