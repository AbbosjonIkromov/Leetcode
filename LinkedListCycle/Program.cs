namespace LinkedListCycle;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Nodes
        var node1 = new ListNode(3);
        var node2 = new ListNode(2);
        var node3 = new ListNode(0);
        var node4 = new ListNode(-4);

        // Oddiy ulash
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;

        // Cycle yaratamiz: -4 -> 2
        node4.next = node2;

        Test(solution, node1); // output true
    }

    static void Test(Solution solution, ListNode? head)
    {
        var result = solution.HasCycle(head);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool HasCycle(ListNode? head)
    {
        if (head == null)
            return false;

        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
                return true;
        }

        return false;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val)
    {
        this.val = val;
        next = null;
    }
}
