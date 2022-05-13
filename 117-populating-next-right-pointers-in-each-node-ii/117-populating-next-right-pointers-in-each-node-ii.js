/**
 * // Definition for a Node.
 * function Node(val, left, right, next) {
 *    this.val = val === undefined ? null : val;
 *    this.left = left === undefined ? null : left;
 *    this.right = right === undefined ? null : right;
 *    this.next = next === undefined ? null : next;
 * };
 */

/**
 * @param {Node} root
 * @return {Node}
 */
 var connectNext = function (root) {
 
    let q = [];
    q.push(root);
    let size = 0;
 
    while (q.length > 0) {
 
        size = q.length;
        let dummy = new Node(0);
 
        while (size-- > 0) {
 
            let temp = q.shift();
 
            dummy.next = temp;
            dummy = dummy.next;
 
            if (temp.left != null)
                q.push(temp.left);
 
            if (temp.right != null)
                q.push(temp.right);
        }
    }
}
 
var connect = function (root) {
    if (root == null)
        return null;
    else
        connectNext(root);
 
    return root;
};