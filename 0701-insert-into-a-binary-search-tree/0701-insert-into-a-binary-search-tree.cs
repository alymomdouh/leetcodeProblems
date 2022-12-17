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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
         if (root is null) return new TreeNode(val);
        TreeNode current = root;
        while(true)
        {
            if(current.val < val)
            {
                if (current.right is null)
                {
                    current.right = new TreeNode(val);
                    return root;
                }
                current = current.right;
            }
            else
            {
                if (current.left is null)
                {
                    current.left = new TreeNode(val);
                    return root;
                }
                current = current.left;
            }
        }
    }
}