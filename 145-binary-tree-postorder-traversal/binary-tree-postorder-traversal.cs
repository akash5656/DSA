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
        Stack<TreeNode> st = new();
        List<int> ans = new();

        if(root == null)
            return [];

        var curr = root;
        TreeNode lastVisited = null;

        while(st.Count > 0 || curr != null)
        {
            while(curr!=null)
            {
                st.Push(curr);
                curr = curr.left;
            }

            var top = st.Peek();
            if(top.right != null && lastVisited != top.right)
                curr = top.right;
            else
            {
                ans.Add(top.val);
                lastVisited = st.Pop();
            }
        }

        
        return ans;
    }
}