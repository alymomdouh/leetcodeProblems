# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

 ##one sol
# class Solution:
#     def getTargetCopy(self, original: TreeNode, cloned: TreeNode, target: TreeNode) -> TreeNode:
#         c_start=cloned
#         stack=[c_start]
#         while stack:
#             node=stack.pop()
#             if node.val==target.val:
#                 return node
#             if node.left:stack.append(node.left)
#             if node.right:stack.append(node.right)    
# 2 sol
class Solution:
    def getTargetCopy(self, original: TreeNode, cloned: TreeNode, target: TreeNode) -> TreeNode:
            def find_node(orignal,copy,find):
                if not orignal:
                    return None
                if orignal == find:
                    return copy
                return find_node(orignal.left,copy.left, find) or find_node(orignal.right,copy.right,find)
            return find_node(original,cloned,target)