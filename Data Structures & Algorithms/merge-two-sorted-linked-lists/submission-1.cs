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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        var curr1 = list1;
        var curr2 = list2;

        
       
        ListNode headRes = new ListNode(-1);
        ListNode currRes = headRes;

        

        while(curr1 != null && curr2 !=null){
            Console.WriteLine("starting");
            Console.WriteLine($"Curr1 {curr1.val } Curr2 {curr2.val}");
            if(curr1.val  <= curr2.val)
            { 
                currRes.next = new ListNode(curr1.val);
                Console.WriteLine("Curr1 added");
                curr1 = curr1.next;
            }
            else 
            {
                currRes.next = new ListNode(curr2.val);
                Console.WriteLine("Curr2 added");
                curr2 = curr2.next;
            }

            currRes = currRes.next;
        }
        Console.WriteLine($"merge Comp Done");

        while(curr1 != null){
            Console.WriteLine($"Curr1 {curr1.val }  ");
            currRes.next = new ListNode(curr1.val);
            curr1 = curr1.next;
            currRes = currRes.next;
        }

        while(curr2 != null){
            Console.WriteLine($" Curr2 {curr2.val}");
            currRes.next = new ListNode(curr2.val);
            curr2 = curr2.next;
            currRes = currRes.next;
        };

        return headRes.next;
    }
}