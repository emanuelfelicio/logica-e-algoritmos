

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

    public IList<int> InorderTraversal(TreeNode root)
    {

        IList<int> result = [];
        Stack<TreeNode> stack = [];
        /*
            RECURSIVE WAY

            void RecursiveInorder(TreeNode root)
            {
                if (root == null) return;
                RecursiveInorder(root.left);
                result.Add(root.val);
                RecursiveInorder(root.right);
            }
            RecursiveInorder(root);

        */
        TreeNode current = root;
        while (current != null || stack.Count != 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }
        return result;
    }

}
