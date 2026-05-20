public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int whiteCount = 0 ; 
        int globalMin = int.MaxValue;

        int left = 0 ; 
        for(int i = 0 ; i<blocks.Length ; i++){

            if(blocks[i] == 'W') whiteCount++;

            if(i-left+1 == k ){
                globalMin = Math.Min(whiteCount , globalMin);

                if(blocks[left] == 'W') whiteCount--;

                left++;

            }
            
        }

        return globalMin;
    }
}