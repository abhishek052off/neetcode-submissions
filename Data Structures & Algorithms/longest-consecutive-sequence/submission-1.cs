public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var set = new HashSet<int>(nums);
        int longestSequance = 0;
        
        foreach(var num in nums){

            if(!set.Contains(num-1)){ // start of sequence
                int currentSequence = 1;
                int currentNum = num+1;
                
                while( set.Contains(currentNum) ) {
                    currentSequence++ ;
                    currentNum++;
                }
                longestSequance = Math.Max(currentSequence , longestSequance);
            }
        }

        return longestSequance;


    }
}
