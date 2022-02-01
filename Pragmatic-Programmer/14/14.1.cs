/**
 * Add method to singly linked list that prints all elements in the list.
 * Node definition below
 *
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

void PrintValues()
{
    ListNode node = self.firstNode;

    while(node != null)
    {
        Console.WriteLine(node.val);
        node = node.next;
    }
}