/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func invertTree(root *TreeNode) *TreeNode {
    if root == nil {
        return nil;
    }

    invert(root);

    return root;
}

func invert(curr *TreeNode) {
    if curr == nil {
        return;
    }

    temp := curr.Left;
    curr.Left = curr.Right;
    curr.Right = temp;

    invert(curr.Left);
    invert(curr.Right);
}