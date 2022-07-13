/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
// var levelOrder = function(root) {
    
// };
var levelOrder = function (root) {

    // Empty tree
    // Return a empty array
    if (!root) {
        return [];
    }

    // Level Order Array, will store each row of the tree
    let level_order_array = [];
    let queue = [root];

    // We're going to be using a iterative approach to this.
    // With use of a queue we're able to achieve level order traversal.
    while (queue.length) {

        // We're going to create a new row each time
        // we encounter a new level.
        let row = [];

        // This is the important part.
        // We keep track of the initial length of the queue
        // We do this because, as we iterate through the queue we don't
        // want to accidentally pick up items from another.
        let queue_len = queue.length;

        // So for every item currently in the queue
        // we're going to add it to the row
        // All the while adding new items to the queue,
        // but because we kept memory of the input length
        // we will only ever pick up the items for that row.
        for (let i = 0; i < queue_len; i++) {

            // Get the node, by popping it off the queue
            let node = queue.pop();

            // Add the node to the row (This row is the given layer)
            row.push(node.val);

            // Just like in a normal level order traversal,
            // when we see a child node, we add it to the queue,
            // but because we kept memory of the input length
            // we won't technically run these children items
            // until we reach their row.
            node.left ? queue.unshift(node.left) : null;
            node.right ? queue.unshift(node.right) : null;
        }

        // So we have gone through the entire queue.
        // Push that row to the level order array.
        level_order_array.push(row);
    }

    return level_order_array;
};
