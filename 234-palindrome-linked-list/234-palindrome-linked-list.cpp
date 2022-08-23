/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    bool isPalindrome(ListNode* head) {
        if (head == NULL)   return true;
        ListNode* p = head;
        vector<int> v;
        while(p){
            v.push_back(p->val);
            p = p->next;
        }
        for (int i = 0; i < v.size()/2; i++){
            if (v[i] == v[v.size() - 1 - i])
                continue;
            else
                return false;
        }
        return true;
    }
};
