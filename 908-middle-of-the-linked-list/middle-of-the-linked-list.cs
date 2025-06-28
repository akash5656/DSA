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
    public ListNode MiddleNode(ListNode head) {
        if(head.next == null)
            return head;

        if(head.next.next == null)
        {
            return head.next;
        }

        ListNode s = head;
        ListNode f = head;

        while(f!=null &&  f.next!=null)
        {
            s = s.next;
            f = f.next.next;
        }

        return s;
    }
}