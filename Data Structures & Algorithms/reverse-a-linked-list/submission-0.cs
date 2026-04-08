/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        // to reverse a list, head must become the next of its next
        
        ListNode curr = head;
        ListNode tail = null;
        while (curr != null) {
            var tmp=curr.next;
            curr.next=tail;
            tail=curr;
            curr=tmp;
        }

        return tail;
    }
}
