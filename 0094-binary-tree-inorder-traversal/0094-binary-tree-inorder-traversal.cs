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
// recursion
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        if (root.left != null) {
            res.AddRange(InorderTraversal(root.left));
        }
        res.Add(root.val);
        if (root.right != null) {
            res.AddRange(InorderTraversal(root.right));
        }
        return res;
    }
}