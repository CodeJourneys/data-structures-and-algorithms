/**
 * Add method to doubly linked list that prints all elements in reverse order.
 *
 * Node definition below
 *
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode prev;
 *     public ListNode(int val=0, ListNode next=null, ListNode prev=null) {
 *         this.val = val;
 *         this.next = next;
 *         this.prev = prev;
 *     }
 * }
 */

 void PrintValuesInReverse()
 {
     ListNode node = self.lastNode;

     while(node != null)
     {
         Console.WriteLine(node.val);
         node = node.prev;
     }
 }