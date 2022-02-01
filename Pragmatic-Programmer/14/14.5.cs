/**
 * Add method to a singly linked list that receives a node from the middle of the list and deletes it.
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

void DeleteNode(ListNode nodeToRemove)
{
    ListNode current = nodeToRemove;
    ListNode next;

    while(next.next != null)
    {
        current.val = next.val;
        current = next;
    }

    // Deallocate/Dispose of next - handled by GC in C#
}