/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
 class Solution {
public:
	int deepestLeavesSum(TreeNode* root) {
	if (root == nullptr)
		return 0;
 
	if (root->left == nullptr && root->right == nullptr)
		return root->val;
 
	queue<TreeNode*> q;
	q.push(root);
 
	int sum = 0, size = 0;
 
	TreeNode* current_node;
 
	while (!q.empty()) {
		sum = 0;
		size = q.size();
 
		for (int i = 0; i < size; i++) {
 
			current_node = q.front();
			q.pop();
 
			sum += current_node->val;
 
			if (current_node->left)
				q.push(current_node->left);
 
			if (current_node->right)
				q.push(current_node->right);
		}
	}
 
	return sum;
}
};