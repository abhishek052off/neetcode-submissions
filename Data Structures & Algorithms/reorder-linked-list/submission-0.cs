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
    public void ReorderList(ListNode head) {
        

        var fast = head ; 
        var slow = head;
        while(fast != null && fast.next != null){
            slow = slow.next; 
            fast = fast.next.next;
        }

        //We have the middle , now reverse the middle 
        var curr = slow.next; 
        slow.next = null;

        ListNode prev = null;

        while(curr != null){
            var next = curr.next;
            curr.next = prev;
            prev = curr; 
            curr = next; 
        }

      var c1 = head; 
      var c2 = prev;

      while(c1 is not null && c2 is not null){

        var next = c2.next;
        c2.next = c1.next;
        c1.next = c2;
        c2 = next;
        c1 = c1.next.next;

      }



     
    }
}
