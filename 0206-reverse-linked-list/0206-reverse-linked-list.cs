/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
// public class Solution {
//     public ListNode ReverseList(ListNode head) {
//          ListNode pre = null, temp = null;
//         while (head != null) {
//             temp = head.next;
//             head.next = pre;
//             pre = head;
//             head = temp;
//         }
//         return pre;
//     }
// }

// recursion
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;
        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return newHead;
    }
}