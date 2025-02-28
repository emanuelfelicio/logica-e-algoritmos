

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int tamanho = 1;
        int meio = 0;
        ListNode? result = new ListNode();
        result = head;
        while (result.next != null)
        {
            tamanho++;
            result = result.next;
        }
        if (tamanho % 2 == 0)
        {
            meio = (tamanho / 2) + 1;
        }
        else
        {
            meio = (tamanho / 2) + 1;
        }
        result = head;

        for (int i = 1; i < meio; i++)
        {
            if (result.next != null)
            {
                result = result.next;
            }
            
        }

        return result;
    }
}

public class Program
{
    public static void Main()
    {
        ListNode head = new ListNode();
    }
}