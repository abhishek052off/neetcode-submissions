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
        
        var fast = head ; 

        for(int i = 1 ; i<= n ; i++){
            fast = fast.next;
            //Console.WriteLine(fast?.val.ToString() ?? "Null");
        }
        
        //Console.WriteLine(fast?.val.ToString() ?? "Null");
        if(fast == null){
            //delete head 
            head = head.next;
            return head;
        }

        var slow = head ; 

        while(fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return head;


    }
}
