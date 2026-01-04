namespace MergeTwoSortedList;

public class Program
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        Test(solution, new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));

    }

    static void Test(Solution sollution, ListNode list1, ListNode list2)
    {
        var result = sollution.MergeTwoLists(list1, list2);
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
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