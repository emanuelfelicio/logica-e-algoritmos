

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


    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        ListNode dummy = head;

        while (dummy.next != null)
        {
            int value1 = dummy.val;
            int value2 = dummy.next.val;
            int mdc = MDC(value1, value2);

            ListNode newNode = new(mdc, dummy.next);
            dummy.next = newNode;
            dummy = newNode.next;

        }

        return head;
    }

    static int MDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

}

