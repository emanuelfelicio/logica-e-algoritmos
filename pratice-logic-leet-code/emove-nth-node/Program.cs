
ListNode list = new();
list.next = new ListNode(10);
ListNode node = list.next;
node.next = new ListNode(30);

Solution solution = new();

solution.RemoveNthFromEnd(list, 1);

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

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int pointer = 1;

        ListNode node = head;

        while (node.next != null)
        {
            node = node.next;
            pointer++;
        }

        node = head;

        while (pointer > n + 1)
        {
            node = node.next;
            pointer--;
        }
        if (pointer == n)
        {
            return node.next;
        }

        ListNode removedNode = node.next;
        node.next = removedNode.next;

        return head;

    }
}