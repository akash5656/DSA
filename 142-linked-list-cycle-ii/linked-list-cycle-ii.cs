/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        
        if(head == null || head.next == null || head.next.next == null)
        {
            return null;
        }

        ListNode s = head;
        ListNode f = head;
        ListNode p = head;
        while(f!=null && f.next!=null)
        {
            s = s.next;
            f = f.next.next;

            if(s == f)
                break;
        }

        if(s!=f)
            return null;

        while(p!=s)
        {
            p=p.next;
            s=s.next;
        }

        return p;
    }
}