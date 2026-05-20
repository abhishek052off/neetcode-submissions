public class Solution {
    public bool hasDuplicate(int[] nums) {
        //store
        var visitedSet = new HashSet<int>();

        foreach(int num in nums){
            
            if(visitedSet.Contains(num)){ //have seen before
                return true;
            } 
            else{
                visitedSet.Add(num);
            }

        }

    return false;

    }
}