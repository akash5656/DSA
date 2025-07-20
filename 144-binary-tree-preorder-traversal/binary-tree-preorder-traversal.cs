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
    List<int> li = new();
    public IList<int> PreorderTraversal(TreeNode root) {

        if(root == null)
            return [];

        Stack<TreeNode> st = new();
        List<int> ans = new();
        st.Push(root);

        while(st.Count > 0)
        {
            var curr = st.Pop();
            ans.Add(curr.val);
            if(curr.right != null)
                st.Push(curr.right);

            if(curr.left != null)
                st.Push(curr.left);
        }

        return ans;
    }
}