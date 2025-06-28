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
    public ListNode DeleteMiddle(ListNode head) {

        if(head.next == null)
        {
            return null;
        }

        if(head.next.next == null)
        {
            head.next = null;
            return head;
        }
        
        ListNode s = head;
        ListNode f = head;
        ListNode prev = head;

        while(f!=null && f.next!=null)
        {
            prev = s;
            s = s.next;
            f = f.next.next;
        }

        prev.next = prev.next.next;

        return head;
    }
}