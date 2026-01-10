namespace RemoveDuplicatesFromSortedList;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new ListNode(1, new ListNode(1, new ListNode(2)))); // output [1, 2]
        Test(solution, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))))); // output [1, 2, 3]
    }
    
    static void Test(Solution solution, ListNode head)
    {
        var result = solution.DeleteDuplicates(head);
        Console.Write("[");
        while (result != null)
        {
            Console.Write(result.val);
            if (result.next != null)
                Console.Write(", ");
            result = result.next;
        }
        Console.WriteLine("]");
    }
}


public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode current = head;

        while(current != null && current.next != null)
        {
            if(current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}