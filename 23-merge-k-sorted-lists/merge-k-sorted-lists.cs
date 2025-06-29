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
    public ListNode MergeKLists(ListNode[] lists) {
        
        if(lists.Length == 0)
            return null;
        
        int s = 0;
        int e = lists.Length-1;

        return PartitionAndMerge(s,e,lists);
    }

    public ListNode MergeTwoSortedLists(ListNode l1,ListNode l2)
    {
        if(l1 == null)
            return l2;
        
        if(l2 == null)
            return l1;
        
        if(l1.val <= l2.val)
        {
            l1.next = MergeTwoSortedLists(l1.next,l2);
            return l1;
        }
        else
        {
            l2.next = MergeTwoSortedLists(l2.next,l1);
            return l2;
        }
    }

    public ListNode PartitionAndMerge(int start,int end,ListNode[] lists)
    {
        if(start==end)
            return lists[end];

        if(start > end)
            return null;
        
        int mid = start + (end-start)/2;

        ListNode l1 = PartitionAndMerge(start,mid,lists);
        ListNode l2 = PartitionAndMerge(mid+1,end,lists);

        return MergeTwoSortedLists(l1,l2);
    }
}