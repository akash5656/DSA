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
    public IList<int> PostorderTraversal(TreeNode root) {
        Stack<TreeNode> st1 = new();
        Stack<TreeNode> st2 = new();

        List<int> ans = new();

        if(root == null)
            return [];

        st1.Push(root);
        while(st1.Count > 0)
        {
            var curr = st1.Pop();
            st2.Push(curr);
            if(curr.left != null)
                st1.Push(curr.left);

            if(curr.right != null)
                st1.Push(curr.right);
        }

        while(st2.Count > 0)
        {
            ans.Add(st2.Pop().val);
        }

        return ans;
    }
}