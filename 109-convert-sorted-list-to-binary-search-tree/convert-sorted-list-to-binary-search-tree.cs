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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        
        if(head == null)
            return null;

        if(head.next == null)
            return new TreeNode(head.val);

        ListNode s = head;
        ListNode f = head;
        ListNode prev = head;

        while(f!=null && f.next!=null)
        {
            prev = s;
            s = s.next;
            f = f.next.next;
        }

        prev.next = null;

        TreeNode root = new TreeNode(s.val);
        root.left = SortedListToBST(head);
        root.right = SortedListToBST(s.next);

        return root;
    }
}