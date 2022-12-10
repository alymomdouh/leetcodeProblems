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
     List<IList<int>> result = new List<IList<int>> ();
    public IList<IList<int>> PathSum (TreeNode root, int sum) {
        List<int> path = new List<int> ();
        Func1 (path, root, sum);
        return result;
    }

    private void Func1 (List<int> path, TreeNode root, int sum) {
        if (root == null) return;
        sum -= root.val;

         List<int> list = new List<int> (path);
        list.Add (root.val);

        if (root.left == null && root.right == null) {
            if (sum == 0) {
                result.Add (list);
                return;
            }
        }

        if (root.left != null) {
            Func1 (list, root.left, sum);
        }

        if (root.right != null) {
            Func1 (list, root.right, sum);
        }
    }
} 