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
    ListNode nodeToDisposeOf = nodeToRemove.next;

    nodeToRemove.val = nodeToRemove.next.val;
    nodeToRemove.next = nodeToRemove.next.next;

    // Deallocate/Dispose of next/nodeToDisposeOf - handled by GC in C#
}