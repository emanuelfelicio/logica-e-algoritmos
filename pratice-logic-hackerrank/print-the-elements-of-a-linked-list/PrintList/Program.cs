

// Complete the printLinkedList function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode next;
 * }
 *
 */
static void printLinkedList(SinglyLinkedListNode head)
{

    SinglyLinkedListNode node = head;

    while (node != null)
    {
        Console.WriteLine(node.data);
        node = node.next;
    }


}

