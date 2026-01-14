namespace SymmetricTree;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        var t1 = new TreeNode(1,
            new TreeNode(2,
                new TreeNode(3),
                new TreeNode(4)),
            new TreeNode(2,
                new TreeNode(4),
                new TreeNode(3)));

        Test(solution, t1); // true

    }
    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.IsSymmetric(root);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while(queue.Count > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();

            if (left == null && right == null)
                continue;
            if(left == null || right == null)
                return false;
            if(left.val != right.val)
                return false;

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);
            queue.Enqueue(left.right);
            queue.Enqueue(right.left);
        }
        return true;
    }
}



public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
