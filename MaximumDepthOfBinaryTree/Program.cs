namespace MaximumDepthOfBinaryTree;

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        var t1 = new TreeNode(3,
            new TreeNode(9),
            new TreeNode(20,
                new TreeNode(15),
                new TreeNode(7)));

        Test(solution, t1); // 3

    }
    static void Test(Solution solution, TreeNode root)
    {
        var result = solution.MaxDepth(root);
        Console.WriteLine($"[{result}]");
    }
}



public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if(root == null)
            return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                if (node == null)
                    continue;
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            depth++;
        }
        return depth;
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