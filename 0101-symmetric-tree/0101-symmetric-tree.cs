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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if( root==null )
            return true;
        
        Stack<TreeNode> leftNode = new Stack<TreeNode>();
        Stack<TreeNode> rightNode = new Stack<TreeNode>();
        
        leftNode.Push( root.left );
        rightNode.Push( root.right );
        
        TreeNode leftTemp;
        TreeNode rightTemp;
        
        while( leftNode.Count != 0 ){
            leftTemp = leftNode.Pop();
            rightTemp = rightNode.Pop();
            if( leftTemp == null && rightTemp == null )
                continue;
            if( leftTemp == null ^ rightTemp == null )//XOR
                return false;
            if( leftTemp.val != rightTemp.val )
                return false;
            
            leftNode.Push( leftTemp.left );
            leftNode.Push( leftTemp.right );
            rightNode.Push( rightTemp.right );
            rightNode.Push( rightTemp.left );
            
        }
        
        return true;
    }
}