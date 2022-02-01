/**
 * Add method to a singly linked list that reverses the list.
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

void ReverseList()
{
    ListNode head = self.firstNode;
    ListNode tail = null;
    ListNode next;
    
    while(head.next != null)
    {
        next = head.next;
        head.next = tail;
        tail = head;
        head = next;
    }

    self.firstNode = tail;
}