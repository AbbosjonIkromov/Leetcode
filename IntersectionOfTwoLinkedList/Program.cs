namespace IntersectionOfTwoLinkedList;

public class Program
{
    static void Main(string[] sender)
    {
        Solution solution = new Solution(); 

        Test(solution, new ListNode(4) { next = new ListNode(1) { next = new ListNode(8) { next = new ListNode(4) { next = new ListNode(5) } } } },
            new ListNode(5) { next = new ListNode(6) { next = new ListNode(1) { next = new ListNode(8) { next = new ListNode(4) { next = new ListNode(5) } } } } }); // output: Intersected at node with value = '8'
    }

    static void Test(Solution solution, ListNode headA, ListNode headB)
    {
        var result = solution.GetIntersectionNode(headA, headB);
        if (result != null)
        {
            Console.WriteLine($"Result: Intersected at node with value = '{result.val}'");
        }
        else
        {
            Console.WriteLine("Result: No intersection found (null)");
        }
    }
}


public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        ListNode pA = headA;
        ListNode pB = headB;

        while (pA != pB)
        {
            pA = (pA == null) ? headB : pA.next;

            pB = (pB == null) ? headA : pB.next;
        }

        return pA;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
