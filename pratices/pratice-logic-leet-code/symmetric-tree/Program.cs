
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
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        Queue<TreeNode> nodes = new();

        if (root == null)
        {
            return true;
        }

        nodes.Enqueue(root.left);
        nodes.Enqueue(root.right);

        while (nodes.Count > 0)
        {
            TreeNode left = nodes.Dequeue();
            TreeNode right = nodes.Dequeue();

            if (left != null && right != null)
            {
                if (left.val != right.val)
                {
                    return false;
                }
                nodes.Enqueue(left.left);
                nodes.Enqueue(right.right);
                nodes.Enqueue(right.left);
                nodes.Enqueue(left.right);

            }
            else if (!(left == null && right == null))
            {
                return false;
            }

        }

        return true;
    }
}