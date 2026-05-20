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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        

        var dummy = new ListNode( -1);
        var newCurr= dummy; 
        
        int carryOver = 0;

        while(l1 != null && l2 != null){

            var sum = (l1.val + l2.val + carryOver);
            carryOver = sum / 10 ;

            newCurr.next = new ListNode(sum%10);
            newCurr = newCurr.next;

            l1 = l1.next;
            l2 = l2.next;


        }

        while(l1 != null){
            var sum =  (l1.val+ carryOver);
            newCurr.next = new ListNode(sum%10);
            carryOver = sum / 10 ;
            newCurr = newCurr.next;
            l1 = l1.next;
        
        }

        while(l2 != null){
             var sum =  (l2.val+ carryOver);
            newCurr.next = new ListNode(sum%10);
            carryOver = sum / 10 ;
            newCurr = newCurr.next;
            l2 = l2.next;
        }

        if(carryOver > 0) newCurr.next = new ListNode(carryOver);




        return dummy.next;
    }
}
