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

        if (head == null || head.next == null) { 
            return false; // If the list is empty or has only one node, it can't have a cycle
        }

        ListNode SlowNode = head, FastNode = head;

        while (FastNode != null && FastNode.next != null) { 
            SlowNode = SlowNode.next;
            FastNode = FastNode.next.next;

            if (SlowNode == FastNode) { // If both pointers meet, there is a cycle
                return true;
            }
        }

        return false; // If we exit the loop, there is no cycle

    }
}