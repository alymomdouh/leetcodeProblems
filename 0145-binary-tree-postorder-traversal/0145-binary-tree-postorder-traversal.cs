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
//     public IList<int> PostorderTraversal(TreeNode root) {
//         var res = new List<int>();
//         if (root == null) return res;
//         if (root.left != null) {
//             res.AddRange(PostorderTraversal(root.left));
//         }
//         if (root.right != null) {
//             res.AddRange(PostorderTraversal(root.right));
//         }
//         res.Add(root.val);
//         return res;
//     }
// }

// iteration1: reverse order insert, similar to two stack.
// public class Solution {
//     public IList<int> PostorderTraversal(TreeNode root) {
//         var res = new List<int>();
//         if (root == null) return res;
//         Stack<TreeNode> stack = new Stack<TreeNode>();
//         stack.Push(root);
//         while (stack.Count > 0) {
//             root = stack.Pop();
//             res.Insert(0, root.val);
//             if (root.left != null) stack.Push(root.left);
//             if (root.right != null) stack.Push(root.right);
//         }
//         return res;
//     }
// }
 
// two stack
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        // Create two stacks
        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();
        // push root to first stack
        s1.Push(root);
        // Run while first stack is not empty
        while (s1.Count > 0) {
            // Pop an item from s1 and push it to s2
            var temp = s1.Pop();
            s2.Push(temp);
            // Push left and right children of removed
            // item to s1
            if (temp.left != null) s1.Push(temp.left);
            if (temp.right != null) s1.Push(temp.right);
        }
        // record all itmes in second stack
        while (s2.Count > 0) {
            var node = s2.Pop();
            res.Add(node.val);
        }
        return res;
    }
}
    