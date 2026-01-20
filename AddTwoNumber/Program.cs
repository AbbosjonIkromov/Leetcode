namespace AddTwoNumber;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var l1 = new ListNode(2,
                    new ListNode(4,
                        new ListNode(3)));

        var l2 = new ListNode(5,
                    new ListNode(6,
                        new ListNode(4)));

        Test(solution, l1, l2);
    }

    static void Test(Solution solution, ListNode l1, ListNode l2)
    {
        var result = solution.AddTwoNumbers(l1, l2);
        while (result != null)
        {
            Console.Write(result.val);
            if (result.next != null) Console.Write(", ");
            result = result.next;
        }
    }
}


public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode(0);
        var cur = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            cur.next = new ListNode(sum % 10);
            carry = sum / 10;
            cur = cur.next;
        }

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