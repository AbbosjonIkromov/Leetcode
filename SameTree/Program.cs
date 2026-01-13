namespace SameTree;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var t1 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));

        var t2 = new TreeNode(1,
            new TreeNode(2),
            new TreeNode(3));
        Test(solution, t1, t2); // true
    }
    static void Test(Solution solution, TreeNode node1, TreeNode node2)
    {
        var result = solution.IsSameTree(node1, node2);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);

        while(queue.Count > 0)
        {
            var node1 = queue.Dequeue();
            var node2 = queue.Dequeue();

            if (node1 == null && node2 == null)
                continue;

            if (node1 == null || node2 == null)
                return false;

            if(node1.val != node2.val)
                return false;

            queue.Enqueue(node1.left);
            queue.Enqueue(node2.left);

            queue.Enqueue(node1.right);
            queue.Enqueue(node2.right);
        }
        return true;
    }
}


public class TreeNode
{
    public int val;
    public TreeNode?left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
