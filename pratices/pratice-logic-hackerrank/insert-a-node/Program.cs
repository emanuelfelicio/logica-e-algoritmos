

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
        }
    }

    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
        if (head == null)
        {
            head = new SinglyLinkedListNode(data);
        }
        else
        {
            SinglyLinkedListNode node = head;
            while (node.next != null)
            {
                node = node.next;
            }

            node.next = new SinglyLinkedListNode(data);
        }

        return head;
    }
}
