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
    public IList<int> InorderTraversal(TreeNode root) {

        Stack<TreeNode> st = new();

        List<int> ans = new();
        var curr = root;
        while(st.Count > 0 || curr != null)
        {
            while(curr != null)
            {
                st.Push(curr);
                curr= curr.left;
            }

            curr = st.Pop();
            ans.Add(curr.val);
            curr = curr.right;

        }

        return ans;
    }
}