namespace InvertBinaryTree;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var root = new TreeNode(1,
        null,
        new TreeNode(2,
        null,
        new TreeNode(3,
            null,
            new TreeNode(4)
                )
            )
        );
        var result = solution.InvertTree(root);
        PrintTree(result);
    }

    static void PrintTree(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine("[]");
            return;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node == null)
            {
                Console.Write("null ");
                continue;
            }

            Console.Write(node.val + " ");

            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
    }
}


public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            var temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        return root;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
     this.val = val;
     this.left = left;
     this.right = right;
    }
}