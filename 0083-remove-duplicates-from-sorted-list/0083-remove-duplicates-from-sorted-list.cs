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
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null)
			return head;
		
		ListNode start = head;
		
		while(start.next != null)
		{
			if(start.val == start.next.val)
				start.next = start.next.next;
			else
				start = start.next;
		}
		return head;
    }
}