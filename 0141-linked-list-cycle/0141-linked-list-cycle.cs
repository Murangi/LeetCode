/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {

        ListNode SlowNode = head, FastNode = head.next;

        if(head == null) {
            return false;
        }

        while(SlowNode != null && SlowNode.next != null) {
            SlowNode = SlowNode.next;
            FastNode = FastNode.next.next;

            if(SlowNode == FastNode) {
                return true;
            }
        }

        return false;
    }
}