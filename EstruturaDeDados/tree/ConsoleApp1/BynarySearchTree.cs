public class BinarySearchTree
{
    private Node? root;
    public void Insert(int value)
    {
        root = InsertHelper(root, new Node(value));
    }


    private Node? InsertHelper(Node? root, Node node)
    {
        if (root == null)
        {
            return node;
        }

        if (node.Value < root.Value)
        {
            root.Left = InsertHelper(root.Left, node);
        }
        else if (node.Value > root.Value)
        {
            root.Right = InsertHelper(root.Right, node);
        }

        return root;
    }

    public void Display()
    {
        DisplayHelper(root);
    }
    private void DisplayHelper(Node? root)
    {
        if (root != null)
        {
            DisplayHelper(root.Left);
            Console.WriteLine(root.Value.ToString());
            DisplayHelper(root.Right);
        }

    }

    public bool Search(int value)
    {
        return SearchHelper(root, value);
    }
    private bool SearchHelper(Node? root, int value)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Value == value)
        {
            return true;
        }

        else if (value < root.Value)
        {
            return SearchHelper(root.Left, value);
        }
        else
        {
            return SearchHelper(root.Right, value);
        }




    }
    public void remove(int value)
    {
        if (Search(value))
        {
            removeHelper(root, value);
        }
        else
        {
            Console.WriteLine($"{value} could not be found");
        }

    }
    private Node? removeHelper(Node? root, int value)
    {
        if (root == null)
        {
            return root;
        }
        else if (value < root.Value)
        {
            root.Left = removeHelper(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = removeHelper(root.Right, value);
        }
        else
        {
            if (root.Left == null && root.Right == null)
            {
                root = null;
            }
            else if (root.Right != null)
            {
                root.Value = Sucessor(root);
                root.Right = removeHelper(root.Right, root.Value);

            }
            else if (root.Left != null)
            {
                root.Value = Antecessor(root);
                root.Left = removeHelper(root.Left, root.Value);
            }
        }

        return root;

    }
    private int Sucessor(Node root)
    {
        root = root.Right!;
        while (root.Left != null)
        {
            root = root.Left;
        }
        return root.Value;
    }
    private int Antecessor(Node root)
    {
        root = root.Left!;
        while (root.Right != null)
        {
            root = root.Right;
        }
        return root.Value;
    }


}