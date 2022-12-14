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
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        if (root.left != null) {
            res.AddRange(PostorderTraversal(root.left));
        }
        if (root.right != null) {
            res.AddRange(PostorderTraversal(root.right));
        }
        res.Add(root.val);
        return res;
    }
}