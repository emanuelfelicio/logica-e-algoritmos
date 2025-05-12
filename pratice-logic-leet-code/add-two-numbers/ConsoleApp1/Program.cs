﻿public class ListNode
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode dummy = new ListNode();
        ListNode cur = dummy;

        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;
            int val = v1 + v2 + carry;
            carry = val / 10;
            val %= 10;
            // instanciando nova lista. palavra chave "new" para criar o objeto
            cur.next = new ListNode(val);
            cur = cur.next;

            // verificando se o Node atual não é nulo
            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }

        }

        return dummy.next;
    }
}
