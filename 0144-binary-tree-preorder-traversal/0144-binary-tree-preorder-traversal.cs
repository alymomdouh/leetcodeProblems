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
// public class Solution {
//     public IList<int> PreorderTraversal(TreeNode root) {
//         var res = new List<int>();
//         if (root == null) return res;
//         res.Add(root.val);
//         if (root.left != null){
//             res.AddRange(PreorderTraversal(root.left));
//         }
//         if (root.right != null) {
//             res.AddRange(PreorderTraversal(root.right));
//         }
//         return res;
//     }
// }

// iteration
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0) {
            var node = stack.Pop();
            res.Add(node.val);
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
        return res;
    }
}