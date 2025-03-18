using System;

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
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var left = head;
        var right = GetMiddle(head);

        var temp = right.next;
        right.next = null;
        right = temp;

        left = SortList(left);
        right = SortList(right);

        return MergeLists(left, right);
    }

    private ListNode GetMiddle(ListNode head)
    {
        var slow = head;
        var fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode MergeLists(ListNode first, ListNode second)
    {
        var dummy = new ListNode();
        var tail = dummy;

        while (first != null && second != null)
        {
            if (first.val < second.val)
            {
                tail.next = first;
                first = first.next;
            }
            else
            {
                tail.next = second;
                second = second.next;
            }
            tail = tail.next;
        }

        if (first != null) tail.next = first;
        if (second != null) tail.next = second;

        return dummy.next;
    }
}

public class Program
{
    public static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");
    }

    public static void Main()
    {
        // Criando a lista 4 -> 2 -> 1 -> 3
        ListNode head = new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));

        Console.WriteLine("Lista original:");
        PrintList(head);

        Solution solution = new Solution();
        ListNode sortedHead = solution.SortList(head);

        Console.WriteLine("Lista ordenada:");
        PrintList(sortedHead);
    }
}
