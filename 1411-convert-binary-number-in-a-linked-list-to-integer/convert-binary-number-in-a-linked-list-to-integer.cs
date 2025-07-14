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
    public int GetDecimalValue(ListNode head) {
        int result = 0;

        ListNode curr = head;

        while(curr != null)
        {
            result = (result << 1) | (curr.val);
            curr = curr.next;
        }
    
        return result;
    }
}