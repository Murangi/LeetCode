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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        int Counter = 0;
        ListNode Temp = head;

        while(Temp != null) {
            Counter++;
            Temp = Temp.next;
        }

        Temp = head;

        int NthValue = Counter -n;

        if(Counter == n) {
            return head.next;
        }
        else
        {

            while(Temp != null) {

                NthValue--;

                if(NthValue == 0)
                    break;

                Temp = Temp.next;    

            }

            Temp.next = Temp.next.next;
        }

        return head;


    }
}