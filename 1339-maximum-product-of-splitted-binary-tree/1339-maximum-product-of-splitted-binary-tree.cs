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
   public int MaxProduct(TreeNode root) {
        int sum = GetSum(root), h = sum / 2, d = GetMinDiff(root, h);
        return (int)(((long)(h + d) % 1000000007) * ((long)(sum - h - d) % 1000000007) % 1000000007);
    }
    private static int GetMinDiff(TreeNode root, int target) {
        if (root == null) {
            return int.MaxValue;
        }
        if (root.val <= target) {
            return root.val - target;
        }
        return new int[] {
            root.val - target,
            GetMinDiff(root.left, target),
            GetMinDiff(root.right, target)
        }.OrderBy(x => Math.Abs(x)).First();
    }
     private static int GetSum(TreeNode root) {
        if (root == null) {
            return 0;
        }
        root.val += GetSum(root.left) + GetSum(root.right);
        return root.val;
    }
}