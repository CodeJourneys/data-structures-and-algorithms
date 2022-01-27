/**
 * Add method to singly linked list that returns the last element from the list.
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

ListNode GetLastNode()
{
    ListNode node = self.firstNode;

    while(node?.next != null)
    {
        node = node.next;
    }

    return node;
}