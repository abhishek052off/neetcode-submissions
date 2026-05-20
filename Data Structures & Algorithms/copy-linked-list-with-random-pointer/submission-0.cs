/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {

        if(head == null) return null;
        
       var dict = new Dictionary<Node , Node>();


       var oldCurrent = head.next;
       var newHead = new Node(head.val);

       var newCurrent = newHead;

       dict[head] = newCurrent;

       while(oldCurrent != null){
         newCurrent.next = new Node(oldCurrent.val);

         newCurrent = newCurrent.next;
         dict[oldCurrent] = newCurrent ;

         oldCurrent = oldCurrent.next;
       }

        oldCurrent = head;
        newCurrent = newHead;


       while(oldCurrent != null && newCurrent != null)
       {
            var oldRandom = oldCurrent.random;
            //What is the new Loaction for this 



            var newLocation = oldRandom == null? null: dict[oldRandom];

            newCurrent.random = newLocation;


            oldCurrent = oldCurrent.next;
            newCurrent = newCurrent.next;
       }


        return newHead;



      
    }
}
